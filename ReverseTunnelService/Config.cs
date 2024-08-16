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
