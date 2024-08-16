using ReverseTunnelService;
using System;
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

			config = Config.LoadConfig("config.json");

			textBoxSshHost.Text = config.sshHost;
			numericSshPort.Value = config.sshPort;
			textBoxSshUsername.Text = config.sshUsername;
			textBoxSshPassword.Text = config.sshPassword;
			numericRemotePort.Value = config.remotePort;
			textBoxLocalAddress.Text = config.localAddress;
			numericLocalPort.Value = config.localPort;
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

		private void buttonToggleConnection_Click(object sender, EventArgs e)
		{
			config.sshHost = textBoxSshHost.Text;
			config.sshPort = (int)numericSshPort.Value;
			config.sshUsername = textBoxSshUsername.Text;
			config.sshPassword = textBoxSshPassword.Text;
			config.remotePort = (uint)numericRemotePort.Value;
			config.localAddress = textBoxLocalAddress.Text;
			config.localPort = (uint)numericLocalPort.Value;

			Config.SaveConfig(config);

			Task.Run(() =>
			{
				buttonToggleConnection.Text = "Restarting...";
				buttonToggleConnection.Enabled = false;
				buttonToggleConnection.Refresh();

				ServiceController controller = new ServiceController("ReverseTunnelService");

				if (controller != null)
				{
					if (controller.Status == ServiceControllerStatus.Running)
					{
						controller.Stop();
						controller.WaitForStatus(ServiceControllerStatus.Stopped);
					}
					controller.Start();
					controller.WaitForStatus(ServiceControllerStatus.Running);

					string lastError = getLastError();
					if (lastError.Length > 0)
					{
						MessageBox.Show(lastError);
						buttonToggleConnection.Text = "Failed";
					}
					else
					{
						buttonToggleConnection.Text = "Apply";
					}
				}
				else
				{
					buttonToggleConnection.Text = "Service not started";
				}

				buttonToggleConnection.Enabled = true;
				buttonToggleConnection.Refresh();
			});
		}

	}
}
