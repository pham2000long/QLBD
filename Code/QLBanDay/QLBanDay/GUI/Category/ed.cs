using QLBanDay.BLL;
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

namespace QLBanDay.GUI.Category
{
    public partial class editcategory : Form
    {
        int ma;
        fCategory fcategory;
        categoryBLL categoryBLL = new categoryBLL();
        public editcategory()
        {
            InitializeComponent();
        }
        public editcategory(fCategory f)
        {
            InitializeComponent();
            fcategory = f;
        }
        public void hienthi(string m,string ten,string mota)
        {
            ma = Int32.Parse(m);
            txtName.Text = ten;
            txtDescription.Text = mota;
        }
        private void editcategory_Load(object sender, EventArgs e)
        {
        }

        private void iconExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditCategory_Click(object sender, EventArgs e)
        {
            categoryBLL.UpdateCategory(ma, txtName.Text, txtDescription.Text);
            fcategory.hienthi();
            this.Close();

        }
    }
}
