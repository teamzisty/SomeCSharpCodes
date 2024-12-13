using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Sample
{
    class Sample
    {
        public static Form form = new Form();
        public static CheckBox checkBox = new CheckBox();
        public static void Main()
        {
            checkBox.Name = "CheckBox";
            checkBox.Text = "DarkMode";

            checkBox.Location = new System.Drawing.Point(12, 12);
            checkBox.Size = new System.Drawing.Size(75, 16);

            checkBox.CheckedChanged += new EventHandler(CheckedChanged);


            form.Controls.Add(checkBox);
            
            form.Name = "Sample";
            form.Text = "Sample";

            form.Size = new System.Drawing.Size(130, 80);
            form.MaximumSize = new System.Drawing.Size(130, 80);
            form.MinimumSize = new System.Drawing.Size(130, 80);
            
            form.MaximizeBox = false;
            form.MinimizeBox = false;
            form.ShowIcon = false;
            
            form.ShowDialog();
        }

        private static void CheckedChanged(object sender, EventArgs e)
        {
            Change(form, checkBox.Checked);
        }

        /*---------------------------------------------------------------------------------------------*/

        [DllImport("dwmapi.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, DWMWINDOWATTRIBUTE attribute, ref int pvAttribute, uint cbAttribute);

        /// <summary>
        /// Change To Lite or Dark TitleBar
        /// </summary>
        /// <param name="form">Target Form</param>
        /// <param name="Dark">Light...false : Dark...true</param>
        public static void Change(Form form, bool Dark)
        {
            int value = Dark ? 1 : 0;
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
