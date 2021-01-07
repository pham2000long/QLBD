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
    public partial class fEditUser : Form
    {
        fUser fnew;
        BLL.usersBLL bll = new BLL.usersBLL();
        public fEditUser()
        {
            InitializeComponent();
        }

        public fEditUser (fUser dataUseredit)
        {
            InitializeComponent();
            fnew = dataUseredit;
            //this.ShowDialog();
            loadDataFromUser();
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridView dgv = fnew.dgv;
                int index = int.Parse(dgv.Rows[fnew.indexUser].Cells[0].Value.ToString());
                string fullName = txtFullnameEdit.Text;
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

                bll.updateUser(account, password, fullName, gend, phone, address, email, "aaa", role, index);
                this.Close();
            } catch(Exception) { }
        }

        private void fEditUser_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
        }
         public void loadDataFromUser()
        {
            DataGridView dgv = fnew.dgv;
            int index = fnew.indexUser;
            txtAccount.Text = dgv.Rows[index].Cells[1].Value.ToString();
            txtPassword.Text = dgv.Rows[index].Cells[2].Value.ToString();
            txtFullnameEdit.Text = dgv.Rows[index].Cells[3].Value.ToString();
            cbGender.Text = dgv.Rows[index].Cells[4].Value.ToString();
            txtPhone.Text = dgv.Rows[index].Cells[5].Value.ToString();
            txtAddress.Text = dgv.Rows[index].Cells[6].Value.ToString();
            txtEmail.Text = dgv.Rows[index].Cells[7].Value.ToString();
            //useredit.avatar = dgv.Rows[index].Cells[8].Value.ToString();
            cbRoleUser.Text = dgv.Rows[index].Cells[9].Value.ToString();
            //.created_at = DateTime.parse(dgv.Rows[index].Cells[10].Value.ToString());
        }

    }

}
