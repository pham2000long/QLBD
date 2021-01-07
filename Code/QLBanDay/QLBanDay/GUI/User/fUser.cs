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

namespace QLBanDay.GUI.User
{
    public partial class fUser : Form
    {
        
        usersBLL userbll = new usersBLL();
        int idUser;
        int d;
        DataGridViewRow row;
        public fUser()
        {
            InitializeComponent();
        }

        public fUser(int idUser)
        {
            InitializeComponent();
            this.idUser = idUser;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            fAddUser f = new fAddUser(this);
            f.ShowDialog();
        }

        public void hienthi()
        {
            List<UsersDTO> dt = userbll.showUser();
            dgvUser.DataSource = dt;
            fLogin f = new fLogin();
            Console.WriteLine(f.setIDUser());
        }

        private void fUser_Load(object sender, EventArgs e)
        {
            hienthi();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Thong bao", "TB", MessageBoxButtons.YesNo);
            //if (MessageBox.Show("Bạn có muốn xóa người dùng này ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //{
            //    userbll.deleteUser(fUser.index.ToString());
            //    fUser_Load(sender, e);
            //}
        }

        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //fUser.index = int.Parse(dgvUser.Rows[e.RowIndex].Cells[0].Value.ToString());
            d = e.RowIndex;
            if (dgvUser.Rows[d] != null)
            {
                btnDeleteUser.Enabled = true;
                btnEditUser.Enabled = true;
            }
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            fEditUser f = new fEditUser(this, dgvUser.Rows[d]);
            f.ShowDialog();
        }

        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
