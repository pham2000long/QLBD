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
namespace QLBanDay.GUI.FormProduct
{
    public partial class fEditProduct : Form
    {
        productsBLL productbll = new productsBLL();
        categoryBLL categoryBLL = new categoryBLL();
        common commomMethodFn = new common();
        fListProduct listProduct;
        List<CategoriesDTO> categories = new List<CategoriesDTO>();
        string colorpro;
        DataGridViewRow row;
        public fEditProduct()
        {
            InitializeComponent();
        }
        public fEditProduct(fListProduct f, int d, DataGridViewRow row)
        {
            InitializeComponent();
            listProduct = f;
            this.row = row;
        }
        public void hienthi()
        {
            txtProduct.Text = row.Cells[1].Value.ToString();
            try {
                pbavatar.Image = Image.FromFile(row.Cells[2].Value.ToString());
            }
            catch(FileNotFoundException x)
            {
                MessageBox.Show("sai đường dẫn ảnh");
            }
            txtprice.Text = row.Cells[3].Value.ToString();
            cbSize.Text = row.Cells[4].Value.ToString();
            cbBrand.Text = row.Cells[5].Value.ToString();
            txtcolor.BackColor = row.Cells[6].Style.BackColor;
            cbgender.Text = row.Cells[7].Value.ToString();
            nudAmount.Text = row.Cells[8].Value.ToString();
            txtDesc.Text = row.Cells[9].Value.ToString();
            colorpro= colorpro = "" + txtcolor.BackColor.A + "," + txtcolor.BackColor.R + "," + txtcolor.BackColor.G + ", " + txtcolor.BackColor.B + "";

            this.FormBorderStyle = FormBorderStyle.None;
            List<CategoriesDTO> categories = categoryBLL.categories();
            for (int i = 0; i < categories.Count; i++)
            {
                if (int.Parse(row.Cells[12].Value.ToString()) == categories[i].ID)
                {
                    cbCategori.Text = categories[i].Name;
                }
                cbCategori.Items.Add(categories[i].Name);
            }

        }
        private void fEditProduct_Load(object sender, EventArgs e)
        {
            hienthi();
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {//gender
            int ID = categoryBLL.getID(cbCategori.Text);
            productbll.Updateproduct(int.Parse(row.Cells[0].Value.ToString()),txtProduct.Text, "a", Int32.Parse(txtprice.Text), Int32.Parse(cbSize.Text), cbBrand.Text, colorpro, "nam", Int32.Parse(nudAmount.Text), txtDesc.Text, ID);
            listProduct.hienthi();
            this.Close();
        }

        private void iconMininum_Click(object sender, EventArgs e)
        {

        }

        private void iconExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChooseColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            Color x = colorDialog1.Color;
            colorpro = "" + x.A + "," + x.R + "," + x.G + ", " + x.B + "";
            txtcolor.BackColor = x;
        }

        private void btnPicture_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "chọn ảnh";
            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            openFileDialog1.InitialDirectory = @"C:\picture";
            Image img;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                img = Image.FromFile(openFileDialog1.FileName);
                pbavatar.Image = img;
            }
        }
    }
}
