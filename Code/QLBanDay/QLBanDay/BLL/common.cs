using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;

namespace QLBanDay
{
    class common
    {
        public void changeColordgv(DataGridView dgv)
        {
            foreach(DataGridViewRow row in dgv.Rows)
            {
                if (row.Index % 2 == 0)
                    row.DefaultCellStyle.BackColor = Color.Lavender;
                else
                    row.DefaultCellStyle.BackColor = Color.White;
                
            }
        }

        ////Close-Maximize-Minimize
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public void MouseDown(Form f)
        {
            ReleaseCapture();
            SendMessage(f.Handle, 0x112, 0xf012, 0);
        }

        public void Exit_Click(Form f)
        {
            f.Close();
        }

        public void Mininum_Click(Form wf)
        {
            wf.WindowState = FormWindowState.Minimized;
        }

        public void Maxinum_Click(Form wf)
        {
            if (wf.WindowState == FormWindowState.Normal)
                wf.WindowState = FormWindowState.Maximized;
            else
                wf.WindowState = FormWindowState.Normal;
        }
    }
}
