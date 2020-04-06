using System;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Threading;
using ConsoleApp1;
using Microsoft.Win32.SafeHandles;
using HardDrive;

namespace Menu
{
    // Token: 0x02000003 RID: 3
    public class Program2
    {
        // Token: 0x06000009 RID: 9
        public static void startSpoof()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Loading...");
            Program2.toel();
        }

        // Token: 0x0600000A RID: 10 RVA: 0x00002528 File Offset: 0x00000728
        public static void toel()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" 1 -> Spoof Harware Serials");
            Console.WriteLine(" 2 -> Clean System");
            Console.WriteLine();
            Console.Write(" -> ");
            string a = Console.ReadLine();
            bool flag = a == "1";
            if (flag)
            {
                Console.Clear();
                Console.Write(" -> ");
                Console.Write("Choose Your serials content (put random words and number, type S48J9L6D1): ");
                SystemBIOS.DownloadDriver();
                SystemBIOS.DownloadSys();
                Thread.Sleep(2000);
                Console.Write(" -> ");
                Console.Write("Old MotherBoard, CPU, Bios and SMBIOS Serials:");
                Console.Write(Program2.GetMotherBoardID());
                SystemBIOS.SystemBiosSpoof();
                Program2.ExecuteCommand("net stop IPHLPSVC");
                Thread.Sleep(500);
                Program2.ExecuteCommand("net stop winmgmt");
                Program2.ExecuteCommand("net start winmgmt");
                Program2.ExecuteCommand("sc stop winmgmt");
                Program2.ExecuteCommand("sc start winmgmt");
                Program2.ExecuteCommand("net start IPHLPSVC");
                Console.Write(" -> ");
                Console.Write("New MotherBoard,CPU,Bios and Smbios Serials:");
                Console.Write(Program2.GetMotherBoardID());
                Diskdrive.DownloadDriver();
                Thread.Sleep(2000);
                Console.Write(" -> ");
                Console.Write("Old DiskDrive Serials:");
                Console.Write(Program2.GetHDDSerial());
                Diskdrive.VolumeID();
                Diskdrive.DiskdriveSpoof();
                Console.Write(" -> ");
                Console.Write("New DiskDrive Serials:");
                Console.Write(Program2.GetHDDSerial());
                Console.Write(" -> ");
                Console.Write("Old MAC:");
                Console.Write(Program2.GetHwid2());
                NtwSpoof.MacDownload();
                NtwSpoof.Mac();
                Thread.Sleep(5000);
                Console.Write(" -> ");
                Console.Write("New MAC:");
                Console.Write(Program2.GetHwid2());
                Console.WriteLine("");
                Console.Write(" -> ");
                Console.Write("Done, press any button to view menu.");
                Console.ReadKey();
                Program2.toel();
            }
            bool flag3 = a == "2";
            if (flag3)
            {
                Console.Clear();
                Console.WriteLine(" -> Cleaning...");
                Traces.Fortnite();
                Traces.Fortnite2();
                Traces.Fortnite3();
                Traces.Fortnite4();
                Traces.Fortnite5();
                Traces.Fortnite6();
                Console.WriteLine(" -> Cleaning Registry...");
                Traces.Registry();
                Traces.Registry2();
                Console.WriteLine(" -> Changing Hostname...");
                Console.WriteLine(" -> Old Hostname: " + Environment.MachineName);
                Traces.Hostname();
                Console.WriteLine(" -> New Hostname: " + Environment.MachineName);
                Console.WriteLine(" -> Done, press any button to view menu.");
                Console.ReadKey();
                Program2.toel();
            }
        }

        // Token: 0x0600000B RID: 11 RVA: 0x000028D0 File Offset: 0x00000AD0
        public static string GetHDDSerial()
        {
            try
            {
                ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_DiskDrive");
                using (ManagementObjectCollection.ManagementObjectEnumerator enumerator = managementObjectSearcher.Get().GetEnumerator())
                {
                    bool flag = enumerator.MoveNext();
                    if (flag)
                    {
                        ManagementObject managementObject = (ManagementObject)enumerator.Current;
                        return managementObject["SerialNumber"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
            }
            return null;
        }

        // Token: 0x0600000C RID: 12 RVA: 0x00002964 File Offset: 0x00000B64
        public static string GetMotherBoardID()
        {
            string text = string.Empty;
            ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_BaseBoard");
            foreach (ManagementBaseObject managementBaseObject in managementObjectSearcher.Get())
            {
                ManagementObject managementObject = (ManagementObject)managementBaseObject;
                text += managementObject["SerialNumber"].ToString();
            }
            return text;
        }

        // Token: 0x0600000D RID: 13 RVA: 0x000029E8 File Offset: 0x00000BE8
        public static string GetHwid2()
        {
            string text = "";
            foreach (NetworkInterface networkInterface in NetworkInterface.GetAllNetworkInterfaces())
            {
                bool flag = networkInterface.OperationalStatus == OperationalStatus.Up;
                bool flag2 = flag;
                if (flag2)
                {
                    text += networkInterface.GetPhysicalAddress().ToString();
                    break;
                }
            }
            return text;
        }

        // Token: 0x0600000E RID: 14 RVA: 0x00002A48 File Offset: 0x00000C48
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

        // Token: 0x0600000F RID: 15 RVA: 0x00002AC0 File Offset: 0x00000CC0
        public static string GetLocalIPAddress()
        {
            IPHostEntry hostEntry = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ipaddress in hostEntry.AddressList)
            {
                bool flag = ipaddress.AddressFamily == AddressFamily.InterNetwork;
                bool flag2 = flag;
                if (flag2)
                {
                    return ipaddress.ToString();
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }

        // Token: 0x06000010 RID: 16 RVA: 0x00002B20 File Offset: 0x00000D20
        public static void Initialize(bool alwaysCreateNewConsole = true)
        {
            bool flag = true;
            bool flag2 = alwaysCreateNewConsole || (Program2.AttachConsole(uint.MaxValue) == 0u && (long)Marshal.GetLastWin32Error() != 5L);
            bool flag3 = flag2;
            bool flag4 = flag3;
            if (flag4)
            {
                flag = (Program2.AllocConsole() != 0);
            }
            bool flag5 = flag;
            bool flag6 = flag5;
            bool flag7 = flag6;
            if (flag7)
            {
                Program2.InitializeOutStream();
                Program2.InitializeInStream();
            }
        }

        // Token: 0x06000011 RID: 17 RVA: 0x00002B80 File Offset: 0x00000D80
        private static void InitializeOutStream()
        {
            FileStream fileStream = Program2.CreateFileStream("CONOUT$", 1073741824u, 2u, FileAccess.Write);
            bool flag = fileStream != null;
            bool flag2 = flag;
            bool flag3 = flag2;
            if (flag3)
            {
                StreamWriter streamWriter = new StreamWriter(fileStream)
                {
                    AutoFlush = true
                };
                Console.SetOut(streamWriter);
                Console.SetError(streamWriter);
            }
        }

        // Token: 0x06000012 RID: 18 RVA: 0x00002BD0 File Offset: 0x00000DD0
        private static void InitializeInStream()
        {
            FileStream fileStream = Program2.CreateFileStream("CONIN$", 2147483648u, 1u, FileAccess.Read);
            bool flag = fileStream != null;
            bool flag2 = flag;
            bool flag3 = flag2;
            if (flag3)
            {
                Console.SetIn(new StreamReader(fileStream));
            }
        }

        // Token: 0x06000013 RID: 19 RVA: 0x00002C0C File Offset: 0x00000E0C
        private static FileStream CreateFileStream(string name, uint win32DesiredAccess, uint win32ShareMode, FileAccess dotNetFileAccess)
        {
            SafeFileHandle safeFileHandle = new SafeFileHandle(Program2.CreateFileW(name, win32DesiredAccess, win32ShareMode, IntPtr.Zero, 3u, 128u, IntPtr.Zero), true);
            bool flag = !safeFileHandle.IsInvalid;
            bool flag2 = flag;
            bool flag3 = flag2;
            FileStream result;
            if (flag3)
            {
                FileStream fileStream = new FileStream(safeFileHandle, dotNetFileAccess);
                result = fileStream;
            }
            else
            {
                result = null;
            }
            return result;
        }

        // Token: 0x06000014 RID: 20
        [DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int AllocConsole();

        // Token: 0x06000015 RID: 21
        [DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, SetLastError = true)]
        private static extern uint AttachConsole(uint dwProcessId);

        // Token: 0x06000016 RID: 22
        [DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CreateFileW(string lpFileName, uint dwDesiredAccess, uint dwShareMode, IntPtr lpSecurityAttributes, uint dwCreationDisposition, uint dwFlagsAndAttributes, IntPtr hTemplateFile);

        // Token: 0x04000003 RID: 3
        private const uint GENERIC_WRITE = 1073741824u;

        // Token: 0x04000004 RID: 4
        private const uint GENERIC_READ = 2147483648u;

        // Token: 0x04000005 RID: 5
        private const uint FILE_SHARE_READ = 1u;

        // Token: 0x04000006 RID: 6
        private const uint FILE_SHARE_WRITE = 2u;

        // Token: 0x04000007 RID: 7
        private const uint OPEN_EXISTING = 3u;

        // Token: 0x04000008 RID: 8
        private const uint FILE_ATTRIBUTE_NORMAL = 128u;

        // Token: 0x04000009 RID: 9
        private const uint ERROR_ACCESS_DENIED = 5u;

        // Token: 0x0400000A RID: 10
        private const uint ATTACH_PARRENT = 4294967295u;
    }
}
