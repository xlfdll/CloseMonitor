using System;
using System.Windows.Forms;

namespace CloseMonitor
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            WinAPIHelper.PostMessage(WinAPIHelper.HWND_BROADCAST, WinAPIHelper.WM_SYSCOMMAND, (Int32)WinAPIHelper.SC_MONITORPOWER, WinAPIHelper.INT_MONITOROFF);
        }
    }
}