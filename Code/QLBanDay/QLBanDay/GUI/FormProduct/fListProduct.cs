using QLBanDay.BLL;
using QLBanDay.DTO;
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
        productsBLL productbll = new productsBLL();
        int d;
        public fListProduct()
        {
            InitializeComponent();
        }
        public void hienthi()
        {
            List<ProductsDTO> dt = productbll.ShowProduct();
            dgvProduct.DataSource = dt;
        }
        private void fListProduct_Load(object sender, EventArgs e)
        {
            hienthi();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            fAddProduct f = new fAddProduct(this);
            f.ShowDialog();
        }

        private void dgvProduct_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < dgvProduct.Rows.Count; i++)
            {
                string[] color = dgvProduct.Rows[i].Cells[6].Value.ToString().Trim('"').Split(',').ToArray();
                dgvProduct.Rows[i].Cells[6].Style.BackColor = Color.FromArgb(int.Parse(color[0]), int.Parse(color[1]), int.Parse(color[2]), int.Parse(color[3]));
                dgvProduct.Rows[i].Cells[6].Style.ForeColor = Color.Transparent;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                fEditProduct f = new fEditProduct(this, d, dgvProduct.Rows[d]);
                f.ShowDialog();
            }
            catch(Exception)
            {
                MessageBox.Show("phải chọn 1 dòng dữ liệu", "thông báo");
            }
        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            d = e.RowIndex;
            try
            {
                if (dgvProduct.Rows[d] != null)
                {
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = true;
                }
            } catch(Exception x)
            {
                MessageBox.Show("Phải chọn một dòng dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa sản phẩm ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                productbll.Deleteproduct(Int32.Parse(dgvProduct.Rows[d].Cells[0].Value.ToString()));
                hienthi();
            }
        }
    }
}
