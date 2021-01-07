
namespace QLBanDay.GUI.FormOrder
{
    partial class fEditSttOrder
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
            this.grbstatus = new System.Windows.Forms.GroupBox();
            this.rdonotpay = new System.Windows.Forms.RadioButton();
            this.rdopayed = new System.Windows.Forms.RadioButton();
            this.btnedit = new System.Windows.Forms.Button();
            this.txtsum = new System.Windows.Forms.TextBox();
            this.cbgioitinh = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnote = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtten = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvproduct = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbstatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproduct)).BeginInit();
            this.SuspendLayout();
            // 
            // grbstatus
            // 
            this.grbstatus.Controls.Add(this.rdonotpay);
            this.grbstatus.Controls.Add(this.rdopayed);
            this.grbstatus.Location = new System.Drawing.Point(59, 349);
            this.grbstatus.Name = "grbstatus";
            this.grbstatus.Size = new System.Drawing.Size(320, 59);
            this.grbstatus.TabIndex = 30;
            this.grbstatus.TabStop = false;
            this.grbstatus.Text = "Trạng thái";
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
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(315, 430);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(125, 24);
            this.btnedit.TabIndex = 28;
            this.btnedit.Text = "Sửa trạng thái";
            this.btnedit.UseVisualStyleBackColor = true;
            // 
            // txtsum
            // 
            this.txtsum.Enabled = false;
            this.txtsum.Location = new System.Drawing.Point(549, 346);
            this.txtsum.Name = "txtsum";
            this.txtsum.Size = new System.Drawing.Size(173, 20);
            this.txtsum.TabIndex = 25;
            // 
            // cbgioitinh
            // 
            this.cbgioitinh.Enabled = false;
            this.cbgioitinh.FormattingEnabled = true;
            this.cbgioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbgioitinh.Location = new System.Drawing.Point(149, 120);
            this.cbgioitinh.Name = "cbgioitinh";
            this.cbgioitinh.Size = new System.Drawing.Size(204, 21);
            this.cbgioitinh.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, -3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Tạo hóa đơn";
            // 
            // txtnote
            // 
            this.txtnote.Enabled = false;
            this.txtnote.Location = new System.Drawing.Point(149, 296);
            this.txtnote.Name = "txtnote";
            this.txtnote.Size = new System.Drawing.Size(204, 20);
            this.txtnote.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(425, 349);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Tổng tiền thanh toán";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Ghi chú";
            // 
            // txtemail
            // 
            this.txtemail.Enabled = false;
            this.txtemail.Location = new System.Drawing.Point(149, 255);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(204, 20);
            this.txtemail.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Email";
            // 
            // txtaddress
            // 
            this.txtaddress.Enabled = false;
            this.txtaddress.Location = new System.Drawing.Point(149, 201);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(204, 20);
            this.txtaddress.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Địa chỉ";
            // 
            // txtsdt
            // 
            this.txtsdt.Enabled = false;
            this.txtsdt.Location = new System.Drawing.Point(149, 158);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(204, 20);
            this.txtsdt.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Số điện thoại";
            // 
            // txtten
            // 
            this.txtten.Enabled = false;
            this.txtten.Location = new System.Drawing.Point(149, 73);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(204, 20);
            this.txtten.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Giới tính";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Tên khách hàng";
            // 
            // dgvproduct
            // 
            this.dgvproduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvproduct.Location = new System.Drawing.Point(519, 73);
            this.dgvproduct.Name = "dgvproduct";
            this.dgvproduct.Size = new System.Drawing.Size(356, 236);
            this.dgvproduct.TabIndex = 8;
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
            // fEditSttOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 482);
            this.Controls.Add(this.dgvproduct);
            this.Controls.Add(this.grbstatus);
            this.Controls.Add(this.btnedit);
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
            this.Name = "fEditSttOrder";
            this.Text = "fEditSttOrder";
            this.Load += new System.EventHandler(this.fEditSttOrder_Load);
            this.grbstatus.ResumeLayout(false);
            this.grbstatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbstatus;
        private System.Windows.Forms.RadioButton rdonotpay;
        private System.Windows.Forms.RadioButton rdopayed;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.TextBox txtsum;
        private System.Windows.Forms.ComboBox cbgioitinh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnote;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvproduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}