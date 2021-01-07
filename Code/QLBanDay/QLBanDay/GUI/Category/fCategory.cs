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
        int d;
        public fCategory()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            fAddCategory f = new fAddCategory(this);
            f.ShowDialog();
        }
        public void hienthi()
        {
            DataTable dt = categoryBLL.ShowCategory();
            dgvCategory.DataSource = dt;
        }
        private void fCategory_Load(object sender, EventArgs e)
        {
            hienthi();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                editcategory edit = new editcategory(this);
                try
                {
                    edit.hienthi(dgvCategory.Rows[d].Cells[0].Value.ToString(), dgvCategory.Rows[d].Cells[1].Value.ToString(), dgvCategory.Rows[d].Cells[2].Value.ToString());
                    edit.ShowDialog();
                } catch (Exception x)
                {
                    MessageBox.Show("Phải chọn một dòng dữ liệu","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(NullReferenceException x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void dgvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            d = e.RowIndex;

                btnEdit.Enabled = true;
                btnDelete.Enabled = true;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa danh mục ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    categoryBLL.DeleteCategory(Int32.Parse(dgvCategory.Rows[d].Cells[0].Value.ToString()));
                    hienthi();
                } catch(Exception x)
                {
                    MessageBox.Show("Phải chọn một dòng dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
