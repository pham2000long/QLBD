using QLBanDay.BLL;
using QLBanDay.DTO;
using QLBanDay.GUI.Category;
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
    public partial class fCategory : Form
    {
        categoryBLL categoryBLL = new categoryBLL();

        public fCategory()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            fAddCategory f = new fAddCategory();
            f.ShowDialog();
        }

        private void fCategory_Load(object sender, EventArgs e)
        {
            DataTable dt = categoryBLL.ShowCategory();
            dgvCategory.DataSource = dt;
        }

    }
}
