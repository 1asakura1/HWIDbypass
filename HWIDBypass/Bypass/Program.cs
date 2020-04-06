using System;
using System.Diagnostics;
using System.Net;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Menu;

namespace Bypass
{
    // Token: 0x02000008 RID: 8
    internal class Program
    {
        // Token: 0x06000038 RID: 56
        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern void BlockInput([MarshalAs(UnmanagedType.Bool)] [In] bool fBlockIt);

        // Token: 0x06000039 RID: 57
        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool AllocConsole();

        // Token: 0x0600003A RID: 58
        [DllImport("kernel32.dll")]
        private static extern IntPtr GetConsoleWindow();

        // Token: 0x0600003B RID: 59
        [DllImport("user32.dll")]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        // Token: 0x0600003C RID: 60 RVA: 0x00003B5C File Offset: 0x00001D5C
        public static void ShowConsoleWindow()
        {
            IntPtr consoleWindow = Program.GetConsoleWindow();
            bool flag = consoleWindow == IntPtr.Zero;
            bool flag2 = flag;
            bool flag3 = flag2;
            if (flag3)
            {
                Program.AllocConsole();
            }
            else
            {
                Program.ShowWindow(consoleWindow, 5);
            }
        }

        // Token: 0x0600003D RID: 61 RVA: 0x00003B98 File Offset: 0x00001D98
        public static void ConsoleHide()
        {
            IntPtr consoleWindow = Program.GetConsoleWindow();
            Program.ShowWindow(consoleWindow, 0);
        }

        // Token: 0x0600003E RID: 62 RVA: 0x00003BB4 File Offset: 0x00001DB4
        public static void ConsoleShow()
        {
            IntPtr consoleWindow = Program.GetConsoleWindow();
            Program.ShowWindow(consoleWindow, 5);
        }

        // Token: 0x0600003F RID: 63 RVA: 0x00003BD0 File Offset: 0x00001DD0
        private static void Main(string[] args)
        {
            Console.Title = "Loading...";
            Program2.startSpoof();
        }
    }
}
