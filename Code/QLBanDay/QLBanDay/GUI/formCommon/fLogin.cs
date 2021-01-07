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
        common com = new common();
        usersBLL users = new usersBLL();
        int id;
        public fLogin()
        {
            InitializeComponent();
        }

        public int setIDUser()
        {
            return id;
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn thoát chương trình không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string error = "";
            if (txtAccount.Text == "")
            {
                error = "Tài khoản không được để trống";
            }
            else if (txtPassword.Text == "")
            {
                error = "Mật khẩu không được để trống";
            }
            //users.getUsernamPassword(txtAccount.Text, txtPassword.Text) != null
            if (error == "")
            {
                string username = txtAccount.Text;
                string password = txtPassword.Text;
                if (!users.getUsernamPassword(username, password))
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không tồn tại");
                }
                else
                {
                    fManager f = new fManager(users.idUser());
                    this.Hide();
                    f.ShowDialog();
                    resetAcc();
                    this.Show();
                }

            }
            else
            {
                MessageBox.Show(error, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void resetAcc()
        {
            txtAccount.Text = "";
            txtPassword.Text = "";
        }

        private void fLogin_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            com.MouseDown(this);
        }
    }
}
