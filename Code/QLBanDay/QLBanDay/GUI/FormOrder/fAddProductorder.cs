using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLBanDay.BLL;
using QLBanDay.DTO;
namespace QLBanDay.GUI.FormOrder
{
    public partial class fAddProductorder : Form
    {
        List<ProductsDTO> dssp = new List<ProductsDTO>();
        productsBLL productsBLL = new productsBLL();
        fAddOrder fAddOrder;
        public fAddProductorder()
        {
            InitializeComponent();
        }
        public fAddProductorder(fAddOrder f)
        {
            InitializeComponent();
            fAddOrder = f;
        }
        private void nudprice_ValueChanged(object sender, EventArgs e)
        {

        }

        private void fAddProductorder_Load(object sender, EventArgs e)
        {
             dssp = productsBLL.ShowProduct();
            for (int i = 0; i < dssp.Count; i++)
            {
                cbproduct.Items.Add(dssp[i].name);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            foreach(ProductsDTO pr in dssp)
            {
                if (pr.name == cbproduct.Text)
                    fAddOrder.addproduct_to_order(pr.id,pr.name, int.Parse(nudprice.Value.ToString()),pr.price);
            }
            fAddOrder.hienthi();
            cbproduct.Text = "";
            nudprice.Value = 0;
        }
    }
}
