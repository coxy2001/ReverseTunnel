using Renci.SshNet;
using System;
using System.Diagnostics;
using System.ServiceProcess;
using System.Timers;

namespace ReverseTunnelService
{
	public partial class ReverseTunnelService : ServiceBase
	{
		private SshClient client;
		private Timer timer;

		public ReverseTunnelService()
		{
			InitializeComponent();
		}

		private void Connect()
		{
			LogEvent("Connecting", EventLogEntryType.Information);
			try
			{
				Config config = Config.LoadConfig();

				client = new SshClient(config.sshHost, config.sshPort, config.sshUsername, config.sshPassword)
				{
					KeepAliveInterval = TimeSpan.FromMinutes(1)
				};
				client.Connect();

				foreach (PortForwardConfig portForward in config.portForwards)
				{
					ForwardedPortRemote port = new ForwardedPortRemote(portForward.remotePort, portForward.localAddress, portForward.localPort);
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
				client.Disconnect();
				LogEvent("Disconnect Success", EventLogEntryType.Information);
			}
			else
			{
				LogEvent("Not connected", EventLogEntryType.Information);
			}
		}

		private void CheckConnection(object sender, ElapsedEventArgs e)
		{
			LogEvent("Checking connection", EventLogEntryType.Information);

			if (client == null || !client.IsConnected)
			{
				Connect();
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

			timer = new Timer(TimeSpan.FromMinutes(5).TotalMilliseconds);
			timer.Elapsed += new ElapsedEventHandler(CheckConnection);
			timer.AutoReset = true;
			timer.Start();
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
