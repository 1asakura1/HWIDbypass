using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;

namespace Xeno
{
	// Token: 0x02000002 RID: 2
	internal class SystemBIOS
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public static void SystemBiosSpoof()
		{
			Process process = new Process();
			process.StartInfo.RedirectStandardInput = true;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.FileName = "cmd.exe";
			process.Start();
			process.StandardInput.WriteLine("cd C:\\Windows");
			process.StandardInput.WriteLine("AMIDEWINx64.exe /BS " + SystemBIOS.Serials);
			process.StandardInput.WriteLine("AMIDEWINx64.exe /SS " + SystemBIOS.Serials);
			process.StandardInput.WriteLine("AMIDEWINx64.exe /SU auto");
			process.StandardInput.WriteLine("AMIDEWINx64.exe /SK " + SystemBIOS.Serials);
			process.StandardInput.WriteLine("AMIDEWINx64.exe /SF " + SystemBIOS.Serials);
			process.StandardInput.WriteLine("AMIDEWINx64.exe /CS " + SystemBIOS.Serials);
			process.StandardInput.WriteLine("AMIDEWINx64.exe /PSN " + SystemBIOS.Serials);
			process.StandardInput.WriteLine("exit");
			process.WaitForExit();
			File.Delete("C:\\Windows\\AMIDEWINx64.exe");
			File.Delete("C:\\Windows\\amifldrv64.sys");
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002198 File Offset: 0x00000398
		public static void DownloadDriver()
		{
			WebClient webClient = new WebClient();
			webClient.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.169 Safari/537.36");
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/614402516381204485/616995784910569473/AMIDEWINx64.exe", "C:\\Windows\\AMIDEWINx64.exe");
			webClient.Proxy = null;
		}

		// Token: 0x06000003 RID: 3 RVA: 0x000021DC File Offset: 0x000003DC
		public static void DownloadSys2()
		{
			WebClient webClient = new WebClient();
			webClient.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.169 Safari/537.36");
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/614402516381204485/616995776588939294/amide.sys", "C:\\Windows\\amide.sys");
			webClient.Proxy = null;
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002220 File Offset: 0x00000420
		public static void DownloadDriver2()
		{
			WebClient webClient = new WebClient();
			webClient.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.169 Safari/537.36");
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/614402516381204485/616995780942888960/AMIDEWIN.EXE", "C:\\Windows\\AMIDEWIN.exe");
			webClient.Proxy = null;
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002264 File Offset: 0x00000464
		public static void DownloadSys()
		{
			WebClient webClient = new WebClient();
			webClient.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.169 Safari/537.36");
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/614402516381204485/616995784818294801/amifldrv64.sys", "C:\\Windows\\amifldrv64.sys");
			webClient.Proxy = null;
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000022A8 File Offset: 0x000004A8
		public static string RandomString(int length)
		{
			return new string((from s in Enumerable.Repeat<string>("0123456789", length)
			select s[SystemBIOS.random.Next(s.Length)]).ToArray<char>());
		}

		// Token: 0x04000001 RID: 1
		public static string Serials = Console.ReadLine();

		// Token: 0x04000002 RID: 2
		private static Random random = new Random();
	}
}
