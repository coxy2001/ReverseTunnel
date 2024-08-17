using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace ReverseTunnelService
{
	public class Config
	{
		public string sshHost { get; set; }
		public int sshPort { get; set; }
		public string sshUsername { get; set; }
		public string sshPassword { get; set; }

		public List<PortForwardConfig> portForwards { get; set; }

		public static string GetPath()
		{
			string path = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
			path = Path.Combine(path, "coxy2001", "Reverse Tunnel");
			if (!Directory.Exists(path))
			{
				Directory.CreateDirectory(path);
			}
			return path;
		}

		public static string GetConfigPath()
		{
			return Path.Combine(GetPath(), "config.json");
		}

		public static Config LoadConfig()
		{
			using (StreamReader r = new StreamReader(GetConfigPath()))
			{
				string json = r.ReadToEnd();
				return JsonSerializer.Deserialize<Config>(json);
			}
		}

		public void SaveConfig()
		{
			string jsonString = JsonSerializer.Serialize(this, new JsonSerializerOptions() { WriteIndented = true });
			using (StreamWriter outputFile = new StreamWriter(GetConfigPath()))
			{
				outputFile.WriteLine(jsonString);
			}
		}
	}

	public class PortForwardConfig
	{
		public uint remotePort { get; set; }
		public string localAddress { get; set; }
		public uint localPort { get; set; }

		public override string ToString()
		{
			return $"{remotePort}:{localAddress}:{localPort}";
		}
	}
}
