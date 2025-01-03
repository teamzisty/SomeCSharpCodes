﻿using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ToDarkTitleBar
{
    internal class ToDarkTitleBar
    {
        [DllImport("dwmapi.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, DWMWINDOWATTRIBUTE attribute, ref int pvAttribute, uint cbAttribute);

        /// <summary>
        /// Change To Dark TitleBar
        /// </summary>
        /// <param name="form">Target Form</param>
        public static void Change(Form form)
        {
            int value = 1;
            DwmSetWindowAttribute(form.Handle, DWMWINDOWATTRIBUTE.DWMWA_USE_IMMERSIVE_DARK_MODE, ref value, (uint)Marshal.SizeOf(typeof(int)));
        }

        private enum DWMWINDOWATTRIBUTE
        {
            DWMWA_USE_IMMERSIVE_DARK_MODE = 20,
            DWMWA_WINDOW_CORNER_PREFERENCE = 33,
            DWMWA_MICA_EFFECT = 1029,
            DWMWA_LAST
        }
    }
}
