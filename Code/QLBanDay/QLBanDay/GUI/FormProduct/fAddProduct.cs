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
    public partial class fAddProduct : Form
    {
        productsBLL productbll = new productsBLL();
        categoryBLL categoryBLL = new categoryBLL();
        common commomMethodFn = new common();
        fListProduct listProduct;
        List<CategoriesDTO> categories = new List<CategoriesDTO>();
        string colorpro="255,255,255,255";


        public fAddProduct()
        {
            InitializeComponent();
        }
        public fAddProduct(fListProduct f)
        {
            InitializeComponent();
            listProduct = f;
        }
        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            commomMethodFn.MouseDown(this);
        }

        private void fAddProduct_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            List<CategoriesDTO> categories = categoryBLL.categories();
            for (int i = 0; i < categories.Count; i++)
            {
                cbCategori.Items.Add(categories[i].Name);
            }

        }

        private void iconMininum_Click(object sender, EventArgs e)
        {
            commomMethodFn.Mininum_Click(this);
        }

        private void ionMaxinum_Click(object sender, EventArgs e)
        {
            commomMethodFn.Maxinum_Click(this); 
        }

        private void iconExit_Click(object sender, EventArgs e)
        {
            commomMethodFn.Exit_Click(this);
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (cbCategori.SelectedItem == null)
            {
                MessageBox.Show("chưa chọn danh mục");
                cbCategori.Focus();
            }
            else
            {
                int ID = categoryBLL.getID(cbCategori.Text);
                if (openFileDialog1.FileName == null)
                { MessageBox.Show("Chưa chọn ảnh"); }
                else
                {
                    try
                    {
                        productbll.Insertproduct(txtProduct.Text, openFileDialog1.FileName, Int32.Parse(txtprice.Text), Int32.Parse(cbSize.Text), cbBrand.Text, colorpro, "nam", Int32.Parse(nudAmount.Text), txtDesc.Text, ID);
                        listProduct.hienthi();
                        this.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("sai kiểu dữ liệu", "lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
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
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
               
                try
                {
                    img = Image.FromFile(openFileDialog1.FileName);
                    pbavatar.Image = img;
                }
                catch (FileNotFoundException x)
                {
                    MessageBox.Show(x.Message);
                }

            }    
            
        }
    }
}
