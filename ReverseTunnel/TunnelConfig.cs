using ReverseTunnelService;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.ServiceProcess;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReverseTunnel
{
	public partial class TunnelConfig : Form
	{
		private readonly Config config;

		public TunnelConfig()
		{
			InitializeComponent();

			try
			{
				config = Config.LoadConfig();

				textBoxSshHost.Text = config.sshHost;
				numericSshPort.Value = config.sshPort;
				textBoxSshUsername.Text = config.sshUsername;
				textBoxSshPassword.Text = config.sshPassword;

				setPortForwardEnabled(false);

				foreach (object item in config.portForwards)
				{
					listBox1.Items.Add(item);
				}
			}
			catch (Exception)
			{
				MessageBox.Show("Failed to load config");
				config = new Config();
			}
		}

		private string getLastError()
		{
			EventLog eventLog = new EventLog
			{
				Source = "ReverseTunnelService",
				Log = "Application"
			};
			int i = eventLog.Entries.Count;
			bool breakNext = false;
			while (i > 0)
			{
				i--;
				EventLogEntry entry = eventLog.Entries[i];
				if (entry.Source == "ReverseTunnelService")
				{
					if (entry.EntryType == EventLogEntryType.Error)
					{
						return entry.Message;
					}
					if (breakNext)
					{
						break;
					}
					breakNext = true;
				}
			}
			return string.Empty;
		}

		private void buttonApply_Click(object sender, EventArgs e)
		{
			config.sshHost = textBoxSshHost.Text;
			config.sshPort = (int)numericSshPort.Value;
			config.sshUsername = textBoxSshUsername.Text;
			config.sshPassword = textBoxSshPassword.Text;

			config.portForwards = new List<PortForwardConfig>();
			foreach (PortForwardConfig item in listBox1.Items)
			{
				config.portForwards.Add(item);
			}

			config.SaveConfig();

			Task.Run(() =>
			{
				buttonApply.Text = "Restarting...";
				buttonApply.Enabled = false;
				buttonApply.Refresh();

				ServiceController controller = new ServiceController("ReverseTunnelService");

				if (controller != null)
				{
					if (controller.Status == ServiceControllerStatus.Running)
					{
						controller.Stop();
						controller.WaitForStatus(ServiceControllerStatus.Stopped, TimeSpan.FromSeconds(30));
					}
					controller.Start();
					controller.WaitForStatus(ServiceControllerStatus.Running, TimeSpan.FromSeconds(30));

					string lastError = getLastError();
					if (lastError.Length > 0)
					{
						MessageBox.Show(lastError);
						buttonApply.Text = "Failed";
					}
					else
					{
						buttonApply.Text = "Apply";
					}
				}
				else
				{
					buttonApply.Text = "Service not started";
				}

				buttonApply.Enabled = true;
				buttonApply.Refresh();
			});
		}

		private void setPortForwardEnabled(bool value)
		{
			numericRemotePort.Enabled = value;
			textBoxLocalAddress.Enabled = value;
			numericLocalPort.Enabled = value;
			buttonSave.Enabled = value;
			buttonDelete.Enabled = value;
		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			PortForwardConfig selected = (PortForwardConfig)listBox1.SelectedItem;
			if (selected != null)
			{
				numericRemotePort.Value = selected.remotePort;
				textBoxLocalAddress.Text = selected.localAddress;
				numericLocalPort.Value = selected.localPort;
				setPortForwardEnabled(true);
			}
		}

		private void buttonSave_Click(object sender, EventArgs e)
		{
			int index = listBox1.SelectedIndex;
			PortForwardConfig selected = (PortForwardConfig)listBox1.Items[index];
			selected.remotePort = (uint)numericRemotePort.Value;
			selected.localAddress = textBoxLocalAddress.Text;
			selected.localPort = (uint)numericLocalPort.Value;
			listBox1.Items[index] = selected;
		}

		private void buttonNew_Click(object sender, EventArgs e)
		{
			listBox1.Items.Add(new PortForwardConfig()
			{
				remotePort = 80,
				localAddress = "127.0.0.1",
				localPort = 80
			});
			listBox1.SelectedIndex = listBox1.Items.Count - 1;
			setPortForwardEnabled(true);
		}

		private void buttonDelete_Click(object sender, EventArgs e)
		{
			int index = listBox1.SelectedIndex;
			listBox1.Items.RemoveAt(index);
			if (index < listBox1.Items.Count)
			{
				listBox1.SelectedIndex = index;

			}
			else if (listBox1.Items.Count > 0)
			{
				listBox1.SelectedIndex = listBox1.Items.Count - 1;
			}
			else
			{
				setPortForwardEnabled(false);
			}
		}
	}
}
