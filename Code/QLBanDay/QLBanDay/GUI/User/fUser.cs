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
        BLL.usersBLL user = new BLL.usersBLL();
        public int index;
        public int indexUser;
        public DataGridView dgv;
        public fUser()
        {
            InitializeComponent();
            
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            fAddUser f = new fAddUser();
            //fUser_Load(sender, e);
            f.ShowDialog();
        }

        private void fUser_Load(object sender, EventArgs e)
        {
            DataTable dt = user.showUser();
            if (dt.Rows.Count > 0)
            {
                List<UsersDTO> listUser = new List<UsersDTO>();
                foreach(DataRow row in dt.Rows)
                {
                    UsersDTO user = new UsersDTO();
                    user.ID = int.Parse(row["id"].ToString());
                    user.UserName = row["username"].ToString();
                    user.Password = row["password"].ToString();
                    user.FullName = row["fullname"].ToString();
                    Boolean genderNumber = Boolean.Parse((row["gender"].ToString()).Trim());
                    user.Gender = genderNumber == true ? "Nam" : "Nữ";
                    user.Phone = row["phone"].ToString();
                    user.Address = row["address"].ToString();
                    user.Email = row["email"].ToString();
                    user.Avatar = row["avatar"].ToString();
                    user.Roles = int.Parse(row["roles"].ToString()) == 1 ? "Admin" : "Nhân viên";
                    user.Created_at = DateTime.Parse(row["created_at"].ToString());
                    user.Updated_at = DateTime.Now;
                    listUser.Add(user);
                }
                dgvUser.DataSource = listUser;
            }
            if(dgvUser.Rows.Count > 0)
            {
                commomMethodFn.changeColordgv(dgvUser);
                
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa người dùng này ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                user.deleteUser(index.ToString());
                fUser_Load(sender, e);
            }
        }

        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                commomMethodFn.changeColordgv(dgvUser);
                index = int.Parse(dgvUser.Rows[e.RowIndex].Cells[0].Value.ToString());
                indexUser = e.RowIndex;
                btnDeleteUser.Enabled = true;
                btnEditUser.Enabled = true;
                dgvUser.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Tomato;
                dgvUser.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
            }
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            dgv = dgvUser;
            fEditUser f = new fEditUser(this);
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fUser_Load(sender, e);
        }
    }
}
