using QLBanDay.GUI.FormProduct;
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
    public partial class fListProduct : Form
    {
        common commomMethodFn = new common();
        public fListProduct()
        {
            InitializeComponent();
        }

        private void fListProduct_Load(object sender, EventArgs e)
        {
            commomMethodFn.changeColordgv(dgvProduct);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            fAddProduct f = new fAddProduct();
            f.ShowDialog();
        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
