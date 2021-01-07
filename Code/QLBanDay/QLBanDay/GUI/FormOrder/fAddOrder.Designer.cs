
namespace QLBanDay.GUI.FormOrder
{
    partial class fAddOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtten = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtnote = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbgioitinh = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtsum = new System.Windows.Forms.TextBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.dgvproduct = new System.Windows.Forms.DataGridView();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btndelete = new System.Windows.Forms.Button();
            this.grbstatus = new System.Windows.Forms.GroupBox();
            this.rdopayed = new System.Windows.Forms.RadioButton();
            this.rdonotpay = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproduct)).BeginInit();
            this.grbstatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên khách hàng";
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(158, 85);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(204, 20);
            this.txtten.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tạo hóa đơn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số điện thoại";
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(158, 170);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(204, 20);
            this.txtsdt.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Địa chỉ";
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(158, 213);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(204, 20);
            this.txtaddress.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Email";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(158, 267);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(204, 20);
            this.txtemail.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ghi chú";
            // 
            // txtnote
            // 
            this.txtnote.Location = new System.Drawing.Point(158, 308);
            this.txtnote.Name = "txtnote";
            this.txtnote.Size = new System.Drawing.Size(204, 20);
            this.txtnote.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(65, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Giới tính";
            // 
            // cbgioitinh
            // 
            this.cbgioitinh.FormattingEnabled = true;
            this.cbgioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbgioitinh.Location = new System.Drawing.Point(158, 132);
            this.cbgioitinh.Name = "cbgioitinh";
            this.cbgioitinh.Size = new System.Drawing.Size(204, 21);
            this.cbgioitinh.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(434, 361);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Tổng tiền thanh toán";
            // 
            // txtsum
            // 
            this.txtsum.Enabled = false;
            this.txtsum.Location = new System.Drawing.Point(558, 358);
            this.txtsum.Name = "txtsum";
            this.txtsum.Size = new System.Drawing.Size(173, 20);
            this.txtsum.TabIndex = 5;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(558, 48);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(108, 27);
            this.btnAddProduct.TabIndex = 6;
            this.btnAddProduct.Text = "Thêm sản phẩm";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // dgvproduct
            // 
            this.dgvproduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvproduct.Location = new System.Drawing.Point(440, 85);
            this.dgvproduct.Name = "dgvproduct";
            this.dgvproduct.Size = new System.Drawing.Size(346, 236);
            this.dgvproduct.TabIndex = 7;
            this.dgvproduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvproduct_CellClick);
            this.dgvproduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvproduct_CellContentClick);
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Location = new System.Drawing.Point(324, 442);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(125, 24);
            this.btnAddOrder.TabIndex = 8;
            this.btnAddOrder.Text = "Tạo hóa đơn";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tên sản phẩm";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Số lượng";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Đơn giá";
            this.Column3.Name = "Column3";
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(684, 48);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(112, 27);
            this.btndelete.TabIndex = 9;
            this.btndelete.Text = "Xóa sản phảm";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // grbstatus
            // 
            this.grbstatus.Controls.Add(this.rdonotpay);
            this.grbstatus.Controls.Add(this.rdopayed);
            this.grbstatus.Location = new System.Drawing.Point(68, 361);
            this.grbstatus.Name = "grbstatus";
            this.grbstatus.Size = new System.Drawing.Size(320, 59);
            this.grbstatus.TabIndex = 10;
            this.grbstatus.TabStop = false;
            this.grbstatus.Text = "Trạng thái";
            // 
            // rdopayed
            // 
            this.rdopayed.AutoSize = true;
            this.rdopayed.Location = new System.Drawing.Point(76, 19);
            this.rdopayed.Name = "rdopayed";
            this.rdopayed.Size = new System.Drawing.Size(93, 17);
            this.rdopayed.TabIndex = 0;
            this.rdopayed.Text = "Đã thanh toán";
            this.rdopayed.UseVisualStyleBackColor = true;
            // 
            // rdonotpay
            // 
            this.rdonotpay.AutoSize = true;
            this.rdonotpay.Checked = true;
            this.rdonotpay.Location = new System.Drawing.Point(203, 19);
            this.rdonotpay.Name = "rdonotpay";
            this.rdonotpay.Size = new System.Drawing.Size(104, 17);
            this.rdonotpay.TabIndex = 0;
            this.rdonotpay.TabStop = true;
            this.rdonotpay.Text = "Chưa thanh toán";
            this.rdonotpay.UseVisualStyleBackColor = true;
            // 
            // fAddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 511);
            this.Controls.Add(this.grbstatus);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.dgvproduct);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.txtsum);
            this.Controls.Add(this.cbgioitinh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnote);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtsdt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtten);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Name = "fAddOrder";
            this.Text = "fAddOrder";
            this.Load += new System.EventHandler(this.fAddOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvproduct)).EndInit();
            this.grbstatus.ResumeLayout(false);
            this.grbstatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtnote;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbgioitinh;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtsum;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.DataGridView dgvproduct;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.GroupBox grbstatus;
        private System.Windows.Forms.RadioButton rdonotpay;
        private System.Windows.Forms.RadioButton rdopayed;
    }
}