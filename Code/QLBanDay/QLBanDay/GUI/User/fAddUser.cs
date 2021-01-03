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
        fUser f = new fUser();
        public fAddUser()
        {
            InitializeComponent();
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
                int gend = (gender.Equals("Nam")) ? 1 : 0;
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
                bll.insertUser(account, password, fullName, gend, phone, address, email, "aaa", role);

            } catch(Exception)
            {
                MessageBox.Show("Các trường không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
}
    }
}
