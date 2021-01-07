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
using QLBanDay.BLL;


namespace QLBanDay.GUI.User
{
    public partial class fEditUser : Form
    {
        common com = new common();
        usersBLL userbll = new usersBLL();
        fUser user;
        DataGridViewRow row;
        public fEditUser()
        {
            InitializeComponent();
        }

        public fEditUser(fUser user, DataGridViewRow row)
        {
            InitializeComponent();
            this.user = user;
            this.row = row;
        }

        public void hienthi()
        {
            txtAccount.Text = row.Cells[1].Value.ToString();
            txtFullname.Text = row.Cells[3].Value.ToString();
            try
            {
                pbAvatar.Image = Image.FromFile(@"" + userbll.imageLink(int.Parse(row.Cells[0].Value.ToString())) + "");
            }
            catch (Exception x)
            {
                MessageBox.Show("Sai đường dẫn ảnh");
            }
            cbGender.Text = row.Cells[5].Value.ToString();
            txtPhone.Text = row.Cells[6].Value.ToString();
            txtAddress.Text = row.Cells[7].Value.ToString();
            txtEmail.Text = row.Cells[8].Value.ToString();
            if (int.Parse(row.Cells[9].Value.ToString()) == 1)
            {
                cbRoleUser.Text = "Admin";
                btnEditUser.Enabled = true;
            }
            else
            {
                cbRoleUser.Text = "Nhân viên";
            }

            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            //userbll.updateUse(int.Parse(row.Cells[0].Value.ToString()), txtProduct.Text, "a", Int32.Parse(txtprice.Text), Int32.Parse(cbSize.Text), cbBrand.Text, colorpro, "nam", Int32.Parse(nudAmount.Text), txtDesc.Text, ID);
            //user.hienthi();
            //this.Close();
        }

        private void fEditUser_Load(object sender, EventArgs e)
        {
            hienthi();
        }

        private void btnAddAvatar_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "chọn ảnh";
            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            openFileDialog1.InitialDirectory = @"C:\picture";
            Image img;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                img = Image.FromFile(openFileDialog1.FileName);
                pbAvatar.Image = img;
            }
        }

        private void iconExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelInforUser_MouseDown(object sender, MouseEventArgs e)
        {
            com.MouseDown(this);
        }
    }
}
