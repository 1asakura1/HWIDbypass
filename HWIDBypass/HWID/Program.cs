using System;
using System.Collections.Generic;
using System.Globalization;
using System.Management;
using System.Security.Cryptography;
using System.Text;

namespace HWID
{
	// Token: 0x02000006 RID: 6
	internal class Program
	{
		// Token: 0x06000020 RID: 32 RVA: 0x0000301B File Offset: 0x0000121B
		public static void Main2()
		{
			Console.WriteLine(Program.Value());
		}

		// Token: 0x06000021 RID: 33 RVA: 0x0000302C File Offset: 0x0000122C
		private static string Value()
		{
			bool flag = string.IsNullOrEmpty(Program._fingerPrint);
			bool flag2 = flag;
			if (flag2)
			{
				Program._fingerPrint = Program.GetHash(string.Concat(new string[]
				{
					"CPU >> ",
					Program.CpuId(),
					"\nBIOS >> ",
					Program.BiosId(),
					"\nBASE >> ",
					Program.BaseId(),
					"\nDISK >> ",
					Program.DiskId(),
					"\nVIDEO >> ",
					Program.VideoId(),
					"\nMAC >> ",
					Program.MacId()
				}));
			}
			return Program._fingerPrint;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000030D0 File Offset: 0x000012D0
		private static string GetHash(string s)
		{
			MD5 md = new MD5CryptoServiceProvider();
			byte[] bytes = Encoding.ASCII.GetBytes(s);
			return Program.GetHexString(md.ComputeHash(bytes));
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00003100 File Offset: 0x00001300
		private static string GetHexString(IList<byte> bt)
		{
			string text = string.Empty;
			for (int i = 0; i < bt.Count; i++)
			{
				byte b = bt[i];
				int num = (int)b;
				int num2 = num & 15;
				int num3 = num >> 4 & 15;
				bool flag = num3 > 9;
				bool flag2 = flag;
				if (flag2)
				{
					text += ((char)(num3 - 10 + 65)).ToString(CultureInfo.InvariantCulture);
				}
				else
				{
					text += num3.ToString(CultureInfo.InvariantCulture);
				}
				bool flag3 = num2 > 9;
				bool flag4 = flag3;
				if (flag4)
				{
					text += ((char)(num2 - 10 + 65)).ToString(CultureInfo.InvariantCulture);
				}
				else
				{
					text += num2.ToString(CultureInfo.InvariantCulture);
				}
				bool flag5 = i + 1 != bt.Count && (i + 1) % 2 == 0;
				bool flag6 = flag5;
				if (flag6)
				{
					text += "-";
				}
			}
			return text;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00003210 File Offset: 0x00001410
		private static string Identifier(string wmiClass, string wmiProperty, string wmiMustBeTrue)
		{
			string text = "";
			ManagementClass managementClass = new ManagementClass(wmiClass);
			ManagementObjectCollection instances = managementClass.GetInstances();
			foreach (ManagementBaseObject managementBaseObject in instances)
			{
				bool flag = managementBaseObject[wmiMustBeTrue].ToString() != "True";
				bool flag2 = !flag;
				if (flag2)
				{
					bool flag3 = text != "";
					bool flag4 = !flag3;
					if (flag4)
					{
						try
						{
							text = managementBaseObject[wmiProperty].ToString();
							break;
						}
						catch
						{
						}
					}
				}
			}
			return text;
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000032D4 File Offset: 0x000014D4
		private static string Identifier(string wmiClass, string wmiProperty)
		{
			string text = "";
			ManagementClass managementClass = new ManagementClass(wmiClass);
			ManagementObjectCollection instances = managementClass.GetInstances();
			foreach (ManagementBaseObject managementBaseObject in instances)
			{
				bool flag = text != "";
				bool flag2 = !flag;
				if (flag2)
				{
					try
					{
						text = managementBaseObject[wmiProperty].ToString();
						break;
					}
					catch
					{
					}
				}
			}
			return text;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00003374 File Offset: 0x00001574
		private static string CpuId()
		{
			string text = Program.Identifier("Win32_Processor", "UniqueId");
			bool flag = text != "";
			bool flag2 = flag;
			string result;
			if (flag2)
			{
				result = text;
			}
			else
			{
				text = Program.Identifier("Win32_Processor", "ProcessorId");
				bool flag3 = text != "";
				bool flag4 = flag3;
				if (flag4)
				{
					result = text;
				}
				else
				{
					text = Program.Identifier("Win32_Processor", "Name");
					bool flag5 = text == "";
					bool flag6 = flag5;
					if (flag6)
					{
						text = Program.Identifier("Win32_Processor", "Manufacturer");
					}
					text += Program.Identifier("Win32_Processor", "MaxClockSpeed");
					result = text;
				}
			}
			return result;
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00003430 File Offset: 0x00001630
		private static string BiosId()
		{
			return string.Concat(new string[]
			{
				Program.Identifier("Win32_BIOS", "Manufacturer"),
				Program.Identifier("Win32_BIOS", "SMBIOSBIOSVersion"),
				Program.Identifier("Win32_BIOS", "IdentificationCode"),
				Program.Identifier("Win32_BIOS", "SerialNumber"),
				Program.Identifier("Win32_BIOS", "ReleaseDate"),
				Program.Identifier("Win32_BIOS", "Version")
			});
		}

		// Token: 0x06000028 RID: 40 RVA: 0x000034BC File Offset: 0x000016BC
		public static string DiskId()
		{
			return Program.Identifier("Win32_DiskDrive", "Model") + Program.Identifier("Win32_DiskDrive", "Manufacturer") + Program.Identifier("Win32_DiskDrive", "Signature") + Program.Identifier("Win32_DiskDrive", "TotalHeads");
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00003510 File Offset: 0x00001710
		private static string BaseId()
		{
			return Program.Identifier("Win32_BaseBoard", "Model") + Program.Identifier("Win32_BaseBoard", "Manufacturer") + Program.Identifier("Win32_BaseBoard", "Name") + Program.Identifier("Win32_BaseBoard", "SerialNumber");
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00003564 File Offset: 0x00001764
		private static string VideoId()
		{
			return Program.Identifier("Win32_VideoController", "DriverVersion") + Program.Identifier("Win32_VideoController", "Name");
		}

		// Token: 0x0600002B RID: 43 RVA: 0x0000359C File Offset: 0x0000179C
		private static string MacId()
		{
			return Program.Identifier("Win32_NetworkAdapterConfiguration", "MACAddress", "IPEnabled");
		}

		// Token: 0x0400000B RID: 11
		private static string _fingerPrint = string.Empty;
	}
}
