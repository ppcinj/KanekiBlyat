using System;
using System.Runtime.InteropServices;

namespace Pong_PowerCore
{
    internal static class PInvoke
    {
        [DllImport("user32.dll")]
        internal static extern short GetAsyncKeyState(System.Windows.Forms.Keys vKey);

        [DllImport("user32.dll")]
        internal static extern bool LockWindowUpdate(IntPtr hWndLock);
    }
}
