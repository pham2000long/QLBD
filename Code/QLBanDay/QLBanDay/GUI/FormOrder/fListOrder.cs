using QLBanDay.BLL;
using QLBanDay.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanDay.GUI.FormOrder
{
    public partial class fListOrder : Form
    {
        ordersBLL ordersBLL = new ordersBLL();
        int d;
        public fListOrder()
        {
            InitializeComponent();
        }
        public void hienThi()
        {
            DataTable dt = ordersBLL.Showorder();
            dgvOrder.DataSource = dt;
        }

        private void fListOrder_Load(object sender, EventArgs e)
        {
            hienThi();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            fAddOrder f = new fAddOrder();
            f.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            fEditSttOrder f = new fEditSttOrder();
            f.ShowDialog();
        }
    }
}
