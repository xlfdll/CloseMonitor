using System;
using System.Runtime.InteropServices;

namespace CloseMonitor
{
    internal static class WinAPIHelper
    {
        [DllImport("user32.dll")]
        internal static extern Int32 PostMessage(IntPtr hWnd, UInt32 Msg, Int32 wParam, Int32 lParam);

        internal const UInt32 WM_SYSCOMMAND = 0x0112;
        internal const UInt32 SC_MONITORPOWER = 0xF170;

        internal static readonly IntPtr HWND_BROADCAST = new IntPtr(0xFFFF);

        internal const Int32 INT_MONITOROFF = 2;
    }
}