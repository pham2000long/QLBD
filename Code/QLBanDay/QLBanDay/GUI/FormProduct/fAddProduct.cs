using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanDay.GUI.FormProduct
{
    public partial class fAddProduct : Form
    {
        common commomMethodFn = new common();
        public fAddProduct()
        {
            InitializeComponent();
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            commomMethodFn.MouseDown(this);
        }

        private void fAddProduct_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void iconMininum_Click(object sender, EventArgs e)
        {
            commomMethodFn.Mininum_Click(this);
        }

        private void ionMaxinum_Click(object sender, EventArgs e)
        {
            commomMethodFn.Maxinum_Click(this); 
        }

        private void iconExit_Click(object sender, EventArgs e)
        {
            commomMethodFn.Exit_Click(this);
        }
    }
}
