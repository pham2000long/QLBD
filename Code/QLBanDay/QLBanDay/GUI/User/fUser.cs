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
        common commomMethodFn = new common();
        usersBLL user = new usersBLL();
        static int index;
        public fUser()
        {
            InitializeComponent();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            fAddUser f = new fAddUser();
            f.ShowDialog();
        }

        private void fUser_Load(object sender, EventArgs e)
        {
            DataTable dt = user.showUser();
            List<UsersDTO> listUser = new List<UsersDTO>();
            foreach(DataRow row in dt.Rows)
            {
                UsersDTO user = new UsersDTO();
                user.ID = int.Parse(row["id"].ToString());
                user.UserName = row["username"].ToString();
                user.Password = row["password"].ToString();
                user.FullName = row["fullname"].ToString();
                //Boolean genderNumber = Boolean.Parse((row["gender"].ToString()));
                //user.Gender = genderNumber == true ? "Nam" : "Nữ";
                Console.WriteLine(row["gender"].ToString());
                user.Phone = row["phone"].ToString();
                user.Address = row["address"].ToString();
                user.Email = row["email"].ToString();
                user.Avatar = row["avatar"].ToString();
                //user.Roles = int.Parse(row["roles"].ToString()) == 1 ? "Admin" : "Nhân viên";
                //user.Created_at = DateTime.Parse(row["created_at"].ToString());
                user.Updated_at = DateTime.Now;
                listUser.Add(user);
            }
            dgvUser.DataSource = listUser;
            commomMethodFn.changeColordgv(dgvUser);
            if(dgvUser.Rows.Count > 0)
            {
                btnDeleteUser.Enabled = true;
                btnEditUser.Enabled = true;
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Thong bao", "TB", MessageBoxButtons.YesNo);
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa người dùng này ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                user.deleteUser(fUser.index.ToString());
                fUser_Load(sender, e);
            }
        }

        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Console.WriteLine();
            fUser.index = int.Parse(dgvUser.Rows[e.RowIndex].Cells[0].Value.ToString());
        }
    }
}
