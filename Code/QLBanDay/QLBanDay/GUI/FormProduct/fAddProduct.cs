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

namespace QLBanDay.GUI.FormProduct
{
    public partial class fAddProduct : Form
    {
        productsBLL productbll = new productsBLL();
        categoryBLL categoryBLL = new categoryBLL();
        common commomMethodFn = new common();
        fListProduct listProduct;
        List<CategoriesDTO> categories = new List<CategoriesDTO>();



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
            int ID = categoryBLL.getID(cbCategori.Text);
            productbll.Insertproduct(txtProduct.Text,"a", Int32.Parse(txtprice.Text), Int32.Parse( cbSize.Text), cbBrand.Text, int.Parse(cbColor.Text), true, cbMaterial.Text, Int32.Parse( txtamount.Text), txtDesc.Text, txtDesc.Text, ID);
        }
    }
}
