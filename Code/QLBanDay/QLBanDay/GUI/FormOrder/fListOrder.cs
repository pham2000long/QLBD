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
        order_detailBLL order_Detail = new order_detailBLL();
        usersBLL user = new usersBLL();
        int d;
        int userid;
        public fListOrder()
        {
            InitializeComponent();
        }

        public fListOrder(int id)
        {
            InitializeComponent();
           userid = id;
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
            fAddOrder f = new fAddOrder(this,userid);
            f.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                fEditSttOrder f = new fEditSttOrder(this, dgvOrder.Rows[d]);
                f.ShowDialog();
            }catch(Exception)
            {
                MessageBox.Show("Phải chọn 1 dòng dữ liệu", "Thông báo");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //   MessageBox.Show("Chắc chắn xóa đơn hàng", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes
            if (dgvOrder.Rows[d].Cells[8].Value.Equals(1) && user.getrole(userid) == 1)
            {
                order_Detail.delete_orderdetail(int.Parse(dgvOrder.Rows[d].Cells[0].Value.ToString()));
                ordersBLL.Deleteorder(int.Parse(dgvOrder.Rows[d].Cells[0].Value.ToString()));
                hienThi();
            }
        }

        private void dgvOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            d = e.RowIndex;
            //try
            //{

            //}
            //catch(Exception)
            //{
            //    MessageBox
            //}
        }
    }
}
