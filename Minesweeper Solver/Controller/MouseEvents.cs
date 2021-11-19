using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Minesweeper_Solver.Controller
{
    class MouseEvents
    {
        [DllImport("user32.dll")]
        static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, IntPtr dwExtraInfo);

        private const UInt32 MOUSEEVENT_LEFTDOWN = 0x0002;
        private const UInt32 MOUSEEVENT_LEFTUP = 0x0004;

        public static void SendClick()
        {
            mouse_event(MOUSEEVENT_LEFTDOWN, 0, 0, 0, new System.IntPtr());
            mouse_event(MOUSEEVENT_LEFTUP, 0, 0, 0, new System.IntPtr());
        }
    }
}
