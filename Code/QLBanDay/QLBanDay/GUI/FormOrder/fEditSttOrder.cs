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

namespace QLBanDay.GUI.FormOrder
{
    public partial class fEditSttOrder : Form
    {
        
        List<Order_detailDTO> productsorder = new List<Order_detailDTO>();
        List<ProductsDTO> lstpro;
        int d;
        int tongtien = 0;
        int userid;
        productsBLL axs = new productsBLL();
        ordersBLL ordersBLL = new ordersBLL();
        order_detailBLL order_DetailBLL = new order_detailBLL();
        fListOrder f;
        public fEditSttOrder()
        {
            InitializeComponent();
        }
        public fEditSttOrder(fListOrder f,DataGridViewRow row)
        {
            InitializeComponent();
            txtten.Text = row.Cells[1].Value.ToString();
            cbgioitinh.Text = row.Cells[2].Value.ToString();
            txtsdt.Text = row.Cells[3].Value.ToString();
            txtaddress.Text = row.Cells[4].Value.ToString();
            txtemail.Text = row.Cells[5].Value.ToString();
            txtnote.Text = row.Cells[6].Value.ToString();
            //txtten.Text = row.Cells[7].Value.ToString();
            rdopayed.Checked = row.Cells[7].Value.Equals(1) ? true : false;
            txtsum.Text = row.Cells[8].Value.ToString();
        }
        private void fEditSttOrder_Load(object sender, EventArgs e)
        {

        }
    }
}
