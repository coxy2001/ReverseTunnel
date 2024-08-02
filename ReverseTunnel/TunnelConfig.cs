using System;
using System.IO;
using System.ServiceProcess;
using System.Text.Json;
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

				try
				{
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

						buttonToggleConnection.Text = "Apply";
					}
					else
					{
						buttonToggleConnection.Text = "Service not started";
					}
				}
				catch
				{
					buttonToggleConnection.Text = "Failed";
				}
				buttonToggleConnection.Enabled = true;
				buttonToggleConnection.Refresh();
			});
		}

	}

	public class Config
	{
		public string sshHost { get; set; }
		public int sshPort { get; set; }
		public string sshUsername { get; set; }
		public string sshPassword { get; set; }

		public uint remotePort { get; set; }
		public string localAddress { get; set; }
		public uint localPort { get; set; }

		public static Config LoadConfig(string path)
		{
			using (StreamReader r = new StreamReader(path))
			{
				string json = r.ReadToEnd();
				return JsonSerializer.Deserialize<Config>(json);
			}
		}

		public static void SaveConfig(Config config)
		{
			string jsonString = JsonSerializer.Serialize(config, new JsonSerializerOptions() { WriteIndented = true });
			using (StreamWriter outputFile = new StreamWriter("config.json"))
			{
				outputFile.WriteLine(jsonString);
			}
		}
	}
}
