using Microsoft.Win32;
using Renci.SshNet;
using System;
using System.Diagnostics;
using System.ServiceProcess;

namespace ReverseTunnelService
{
	public partial class ReverseTunnelService : ServiceBase
	{
		private SshClient client;
		private ForwardedPortRemote port;

		public ReverseTunnelService()
		{
			InitializeComponent();
		}

		private void Connect()
		{
			LogEvent("Connecting", EventLogEntryType.Information);
			try
			{
				string configPath;

				using (RegistryKey key = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Services\\ReverseTunnelService"))
				{
					configPath = key.GetValue("ImagePath").ToString();
				}

				LogEvent(configPath, EventLogEntryType.Information);

				string[] parts = configPath.Replace("\"", string.Empty).Split('\\');
				parts[parts.Length - 1] = "config.json";
				configPath = string.Join("\\", parts);

				LogEvent(configPath, EventLogEntryType.Information);

				Config config = Config.LoadConfig(configPath);

				client = new SshClient(config.sshHost, config.sshPort, config.sshUsername, config.sshPassword);
				client.Connect();

				foreach (var portForward in config.portForwards)
				{
					port = new ForwardedPortRemote(portForward.remotePort, portForward.localAddress, portForward.localPort);
					client.AddForwardedPort(port);
					port.Start();
				}

				LogEvent("Connect Success", EventLogEntryType.Information);
			}
			catch (Exception ex)
			{
				LogEvent("Connect Failed", EventLogEntryType.Error);
				LogEvent(ex.ToString(), EventLogEntryType.Error);
			}
		}

		private void Disconnect()
		{
			LogEvent("Disconnecting", EventLogEntryType.Information);
			if (client != null && client.IsConnected)
			{
				port.Stop();
				client.Disconnect();
				LogEvent("Disconnect Success", EventLogEntryType.Information);
			}
			else
			{
				LogEvent("Not connected", EventLogEntryType.Information);
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
			{
				EventLog.CreateEventSource("ReverseTunnelService", "Application");
			}

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
}
