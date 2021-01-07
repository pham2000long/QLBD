using QLBanDay.BLL;
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
    public partial class fAddUser : Form
    {
        common commomMethodFn = new common();
        usersBLL bll = new usersBLL();
        fUser ListUsers = new fUser();
        public fAddUser()
        {
            InitializeComponent();
        }
        public fAddUser(fUser f)
        {
            InitializeComponent();
            ListUsers = f;
        }
        private void iconMininum_Click(object sender, EventArgs e)
        {
            commomMethodFn.Mininum_Click(this);
        }

        private void iconExit_Click(object sender, EventArgs e)
        {
            commomMethodFn.Exit_Click(this);
        }

        private void fAddUser_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            try
            {
                string fullName = txtFullname.Text;
                string gender = cbGender.SelectedItem.ToString();
                string account = txtAccount.Text;
                string password = txtPassword.Text;
                string email = txtEmail.Text;
                string phone = txtPhone.Text;
                string address = txtAddress.Text;
                string roleName = cbRoleUser.SelectedItem.ToString();
                int role = 0;
                if (roleName.Equals("Admin"))
                    role = 1;
                else if (roleName.Equals("Nhân viên"))
                    role = 2;
                bll.insertUser(account, password, fullName, gender, phone, address, email, role);
                ListUsers.hienthi();
                this.Close();

            } catch(Exception)
            {
                MessageBox.Show("Các trường không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
}
    }
}
