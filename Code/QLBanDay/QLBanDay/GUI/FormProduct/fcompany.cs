using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanDay
{
    public partial class fcompany : Form
    {
        common commomMethodFn = new common();
        public fcompany()
        {
            InitializeComponent();
        }

        private void fcompany_Load(object sender, EventArgs e)
        {
            commomMethodFn.changeColordgv(dgvCompany);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            fAddCompany f = new fAddCompany();
            f.ShowDialog();
        }
    }
}
