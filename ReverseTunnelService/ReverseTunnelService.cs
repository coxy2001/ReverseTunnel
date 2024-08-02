using Microsoft.Win32;
using Renci.SshNet;
using System.Diagnostics;
using System.IO;
using System.ServiceProcess;
using System.Text.Json;

namespace ReverseTunnelService
{
	public partial class ReverseTunnelService : ServiceBase
	{
		SshClient client;
		ForwardedPortRemote port;

		public ReverseTunnelService()
		{
			InitializeComponent();
		}

		private void Connect()
		{
			this.LogEvent("Connecting", EventLogEntryType.Information);
			try
			{
				string configPath;

				using (RegistryKey key = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Services\\ReverseTunnelService"))
				{
					configPath = key.GetValue("ImagePath").ToString();
				}

				this.LogEvent(configPath, EventLogEntryType.Information);

				string[] parts = configPath.Replace("\"", string.Empty).Split('\\');
				parts[parts.Length - 1] = "config.json";
				configPath = string.Join("\\", parts);

				this.LogEvent(configPath, EventLogEntryType.Information);

				Config config = Config.LoadConfig(configPath);

				client = new SshClient(config.sshHost, config.sshPort, config.sshUsername, config.sshPassword);
				client.Connect();

				port = new ForwardedPortRemote(config.remotePort, config.localAddress, config.localPort);
				client.AddForwardedPort(port);
				port.Start();

				this.LogEvent("Connect Success", EventLogEntryType.Information);
			}
			catch
			{
				this.LogEvent("Connect Failed", EventLogEntryType.Error);
			}
		}

		private void Disconnect()
		{
			this.LogEvent("Disconnecting", EventLogEntryType.Information);
			if (client != null && client.IsConnected)
			{
				port.Stop();
				client.Disconnect();
				this.LogEvent("Disconnect Success", EventLogEntryType.Information);
			}
			else
			{
				this.LogEvent("Not connected", EventLogEntryType.Information);
			}
		}

		private void LogEvent(string message, EventLogEntryType entryType)
		{
			EventLog eventLog = new EventLog
			{
				Source = "ReverseTunnelService",
				Log = "Application"
			};
			eventLog.WriteEntry(message, entryType);
		}

		protected override void OnStart(string[] args)
		{
			if (!EventLog.SourceExists("ReverseTunnelService"))
				EventLog.CreateEventSource("ReverseTunnelService", "Application");

			Connect();
		}

		protected override void OnContinue()
		{
			Connect();
		}

		protected override void OnStop()
		{
			Disconnect();
		}

		protected override void OnPause()
		{
			Disconnect();
		}

		protected override void OnShutdown()
		{
			Disconnect();
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
