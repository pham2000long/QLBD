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
using System.IO;

namespace QLBanDay.GUI.User
{
    public partial class fAddUser : Form
    {
        usersBLL usersbll = new usersBLL();
        common commomMethodFn = new common();
        fUser listUser;
        public fAddUser()
        {
            InitializeComponent();
        }

        public fAddUser(fUser listUser)
        {
            InitializeComponent();
            this.listUser = listUser;
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
            if (openFileDialog1.FileName == null)
            { MessageBox.Show("Chưa chọn ảnh"); }
            else
            {
                try
                {
                    int roleUser;
                    if (cbRoleUser.Text == "Admin")
                    {
                        roleUser = 1;
                    }
                    else
                    {
                        roleUser = 2;
                    }
                    usersbll.insertUser(txtAccount.Text, txtPassword.Text, txtFullname.Text, openFileDialog1.FileName, cbGender.Text, txtPhone.Text, txtAddress.Text, txtEmail.Text, roleUser);
                    listUser.hienthi();
                    this.Close();
                }
                catch (Exception x)
                {
                    MessageBox.Show("Sai kiểu dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAddAvatar_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Chọn ảnh";
            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            openFileDialog1.InitialDirectory = @"C:\picture";
            Image img;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                try
                {
                    img = Image.FromFile(openFileDialog1.FileName);
                    pbAvatar.Image = img;
                }
                catch (FileNotFoundException x)
                {
                    MessageBox.Show(x.Message);
                }

            }
        }

        private void panelInforUser_MouseDown(object sender, MouseEventArgs e)
        {
            commomMethodFn.MouseDown(this);
        }
    }
}
