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

namespace QLBanDay
{
    public partial class fLogin : Form
    {
        usersBLL users = new usersBLL();
        public fLogin()
        {
            InitializeComponent();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn thoát chương trình không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string error = "";
            if(txtAccount.Text == "")
            {
                error = "User khong duoc de trong";
            }
            else if(txtPassword.Text == "")
            {
                error = "Password khong duoc de trong";
            }
            //users.getUsernamPassword(txtAccount.Text, txtPassword.Text) != null
            if(error == "")
            {
                string username = txtAccount.Text;
                string password = txtPassword.Text;
                if (!users.getUsernamPassword(username, password))
                {
                    MessageBox.Show("Username or Password khong ton tai");
                }
                else
                {
                    fManager f = new fManager();
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
            }
            
            else
            {
                MessageBox.Show(error);
            }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {

        }

        private void fLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
