using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace idk
{
	public static class KeyDecoder
	{
		public static string GetWindowsProductKeyFromRegistry()
		{
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32);
			RegistryKey registryKey2 = registryKey.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion");
			object obj = (registryKey2 != null) ? registryKey2.GetValue("DigitalProductId") : null;
			bool flag = obj == null;
			string result;
			if (flag)
			{
				result = "Failed to get DigitalProductId from registry";
			}
			else
			{
				byte[] digitalProductId = (byte[])obj;
				registryKey.Close();
				bool flag2 = (Environment.OSVersion.Version.Major == 6 && Environment.OSVersion.Version.Minor >= 2) || Environment.OSVersion.Version.Major > 6;
				result = KeyDecoder.GetWindowsProductKeyFromDigitalProductId(digitalProductId, flag2 ? DigitalProductIdVersion.Windows8AndUp : DigitalProductIdVersion.UpToWindows7);
			}
			return result;
		}

		public static string GetWindowsProductKeyFromDigitalProductId(byte[] digitalProductId, DigitalProductIdVersion digitalProductIdVersion)
		{
			return (digitalProductIdVersion == DigitalProductIdVersion.Windows8AndUp) ? KeyDecoder.DecodeProductKeyWin8AndUp(digitalProductId) : KeyDecoder.DecodeProductKey(digitalProductId);
		}

		private static string DecodeProductKey(byte[] digitalProductId)
		{
			char[] array = new char[]
			{
			'B',
			'C',
			'D',
			'F',
			'G',
			'H',
			'J',
			'K',
			'M',
			'P',
			'Q',
			'R',
			'T',
			'V',
			'W',
			'X',
			'Y',
			'2',
			'3',
			'4',
			'6',
			'7',
			'8',
			'9'
			};
			char[] array2 = new char[29];
			ArrayList arrayList = new ArrayList();
			for (int i = 52; i <= 67; i++)
			{
				arrayList.Add(digitalProductId[i]);
			}
			for (int j = 28; j >= 0; j--)
			{
				bool flag = (j + 1) % 6 == 0;
				if (flag)
				{
					array2[j] = '-';
				}
				else
				{
					int num = 0;
					for (int k = 14; k >= 0; k--)
					{
						int num2 = num << 8 | (int)((byte)arrayList[k]);
						arrayList[k] = (byte)(num2 / 24);
						num = num2 % 24;
						array2[j] = array[num];
					}
				}
			}
			return new string(array2);
		}

		public static string DecodeProductKeyWin8AndUp(byte[] digitalProductId)
		{
			string text = string.Empty;
			byte b = (byte)(digitalProductId[66] / 6 & 1);
			digitalProductId[66] = ((byte)((digitalProductId[66] & 247) | (b & 2) * 4));
			int num = 0;
			for (int i = 24; i >= 0; i--)
			{
				int num2 = 0;
				for (int j = 14; j >= 0; j--)
				{
					num2 *= 256;
					num2 = (int)digitalProductId[j + 52] + num2;
					digitalProductId[j + 52] = (byte)(num2 / 24);
					num2 %= 24;
					num = num2;
				}
				text = "BCDFGHJKMPQRTVWXY2346789"[num2].ToString() + text;
			}
			string str = text.Substring(1, num);
			string str2 = text.Substring(num + 1, text.Length - (num + 1));
			text = str + "N" + str2;
			for (int k = 5; k < text.Length; k += 6)
			{
				text = text.Insert(k, "-");
			}
			return text;
		}
	}
}
