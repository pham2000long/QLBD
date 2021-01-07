using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLBanDay.DTO;
using QLBanDay.BLL;
namespace QLBanDay.GUI.FormOrder
{
    public partial class fAddOrder : Form
    {
        productsBLL axs = new productsBLL();
        List<Order_detailDTO> productsorder =new List<Order_detailDTO>();
        List<ProductsDTO> lstpro;
        int d;
        int tongtien=0;
        int userid;
         ordersBLL ordersBLL = new ordersBLL();
        order_detailBLL order_DetailBLL = new order_detailBLL();
        public fAddOrder()
        {
            InitializeComponent();
            lstpro = axs.ShowProduct();
        }
        public fAddOrder(int userid)
        {
            InitializeComponent();
            lstpro = axs.ShowProduct();
            this.userid = userid;
        }
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            fAddProductorder f=new fAddProductorder(this);
            f.ShowDialog();
        }
        public void addproduct_to_order(int product_id,string ten,int quantity,int price)
        {
            Order_detailDTO productor = new Order_detailDTO();
            productor.product_id = product_id;
            productor.product_name = ten;
            productor.quantity = quantity;
            productor.price = quantity * price;
            productsorder.Add(productor);
            tongtien = tongtien + productor.price;
            txtsum.Text = tongtien.ToString();
        }
        public void hienthi()
        {
            dgvproduct.Rows.Clear();
            dgvproduct.Rows.Add();

            for(int i=0;i<productsorder.Count;i++)
            {
                dgvproduct.Rows[i].Cells[0].Value = productsorder[i].product_name;
                dgvproduct.Rows[i].Cells[1].Value = productsorder[i].quantity;
                dgvproduct.Rows[i].Cells[2].Value = productsorder[i].price;
                dgvproduct.Rows.Add();
            }

        }
        private void dgvproduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fAddOrder_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            ordersBLL.Insertorder(txtten.Text, cbgioitinh.Text, int.Parse(txtsdt.Text.ToString()), txtaddress.Text, txtemail.Text, txtnote.Text,tongtien,rdopayed.Checked?1:0,userid);
            int orderid = ordersBLL.getid();
            foreach(Order_detailDTO pro in productsorder)
            {
                order_DetailBLL.insert_order_detail(orderid, pro.product_id, pro.quantity);
            }


        }

        private void dgvproduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
                d = e.RowIndex;

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
        try
        {
                tongtien -= productsorder[d].price;
                productsorder.RemoveAt(d);
                d = -1;
                txtsum.Text = tongtien.ToString();
                 hienthi();
        }
        catch (Exception)
            {
                MessageBox.Show("Chọn 1 sản phẩm");
            }
        }
    }
}
