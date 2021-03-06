﻿
namespace QLBanDay.GUI.User
{
    partial class fAddUser
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pbAvatar = new System.Windows.Forms.PictureBox();
            this.btnAddAvatar = new System.Windows.Forms.Button();
            this.iconMininum = new FontAwesome.Sharp.IconPictureBox();
            this.iconExit = new FontAwesome.Sharp.IconPictureBox();
            this.ionMaxinum = new FontAwesome.Sharp.IconPictureBox();
            this.cbRoleUser = new System.Windows.Forms.ComboBox();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFullname = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelInforUser = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMininum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ionMaxinum)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelInforUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pbAvatar
            // 
            this.pbAvatar.Location = new System.Drawing.Point(45, 93);
            this.pbAvatar.Name = "pbAvatar";
            this.pbAvatar.Size = new System.Drawing.Size(156, 162);
            this.pbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAvatar.TabIndex = 35;
            this.pbAvatar.TabStop = false;
            // 
            // btnAddAvatar
            // 
            this.btnAddAvatar.Location = new System.Drawing.Point(45, 268);
            this.btnAddAvatar.Name = "btnAddAvatar";
            this.btnAddAvatar.Size = new System.Drawing.Size(75, 23);
            this.btnAddAvatar.TabIndex = 34;
            this.btnAddAvatar.Text = "Chọn ảnh";
            this.btnAddAvatar.UseVisualStyleBackColor = true;
            this.btnAddAvatar.Click += new System.EventHandler(this.btnAddAvatar_Click);
            // 
            // iconMininum
            // 
            this.iconMininum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconMininum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(40)))));
            this.iconMininum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(134)))), ((int)(((byte)(60)))));
            this.iconMininum.IconChar = FontAwesome.Sharp.IconChar.Circle;
            this.iconMininum.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(134)))), ((int)(((byte)(60)))));
            this.iconMininum.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconMininum.IconSize = 30;
            this.iconMininum.Location = new System.Drawing.Point(669, 11);
            this.iconMininum.Name = "iconMininum";
            this.iconMininum.Size = new System.Drawing.Size(30, 30);
            this.iconMininum.TabIndex = 31;
            this.iconMininum.TabStop = false;
            // 
            // iconExit
            // 
            this.iconExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(40)))));
            this.iconExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.iconExit.IconChar = FontAwesome.Sharp.IconChar.Circle;
            this.iconExit.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.iconExit.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconExit.IconSize = 30;
            this.iconExit.Location = new System.Drawing.Point(741, 11);
            this.iconExit.Name = "iconExit";
            this.iconExit.Size = new System.Drawing.Size(30, 30);
            this.iconExit.TabIndex = 32;
            this.iconExit.TabStop = false;
            this.iconExit.Click += new System.EventHandler(this.iconExit_Click);
            // 
            // ionMaxinum
            // 
            this.ionMaxinum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ionMaxinum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(40)))));
            this.ionMaxinum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(239)))), ((int)(((byte)(115)))));
            this.ionMaxinum.IconChar = FontAwesome.Sharp.IconChar.Circle;
            this.ionMaxinum.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(239)))), ((int)(((byte)(115)))));
            this.ionMaxinum.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.ionMaxinum.IconSize = 30;
            this.ionMaxinum.Location = new System.Drawing.Point(705, 11);
            this.ionMaxinum.Name = "ionMaxinum";
            this.ionMaxinum.Size = new System.Drawing.Size(30, 30);
            this.ionMaxinum.TabIndex = 33;
            this.ionMaxinum.TabStop = false;
            // 
            // cbRoleUser
            // 
            this.cbRoleUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbRoleUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRoleUser.FormattingEnabled = true;
            this.cbRoleUser.Location = new System.Drawing.Point(237, 304);
            this.cbRoleUser.Name = "cbRoleUser";
            this.cbRoleUser.Size = new System.Drawing.Size(234, 33);
            this.cbRoleUser.TabIndex = 3;
            // 
            // cbGender
            // 
            this.cbGender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbGender.Location = new System.Drawing.Point(501, 90);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(234, 33);
            this.cbGender.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Gainsboro;
            this.label12.Location = new System.Drawing.Point(41, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(180, 24);
            this.label12.TabIndex = 6;
            this.label12.Text = "Thông tin cá nhân";
            // 
            // txtPhone
            // 
            this.txtPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(501, 238);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(234, 30);
            this.txtPhone.TabIndex = 6;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(501, 167);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(234, 30);
            this.txtPassword.TabIndex = 6;
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(239)))), ((int)(((byte)(115)))));
            this.btnAddUser.FlatAppearance.BorderSize = 0;
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.ForeColor = System.Drawing.Color.White;
            this.btnAddUser.Location = new System.Drawing.Point(621, 21);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(114, 40);
            this.btnAddUser.TabIndex = 0;
            this.btnAddUser.Text = "Thêm";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // txtAccount
            // 
            this.txtAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccount.Location = new System.Drawing.Point(237, 167);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(234, 30);
            this.txtAccount.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(237, 238);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(234, 30);
            this.txtEmail.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(234, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Quyền hạng";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Gainsboro;
            this.label10.Location = new System.Drawing.Point(500, 215);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 17);
            this.label10.TabIndex = 5;
            this.label10.Text = "Điện thoại";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(498, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mật khẩu";
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(237, 387);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(498, 30);
            this.txtAddress.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(234, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tài khoản";
            // 
            // txtFullname
            // 
            this.txtFullname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullname.Location = new System.Drawing.Point(237, 93);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Size = new System.Drawing.Size(234, 30);
            this.txtFullname.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gainsboro;
            this.label9.Location = new System.Drawing.Point(234, 215);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 17);
            this.label9.TabIndex = 5;
            this.label9.Text = "Email";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(234, 364);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Địa chỉ";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gainsboro;
            this.label8.Location = new System.Drawing.Point(498, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "Giới tính";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(234, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Họ tên";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(40)))));
            this.panel2.Controls.Add(this.btnAddUser);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 450);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(782, 96);
            this.panel2.TabIndex = 41;
            // 
            // panelInforUser
            // 
            this.panelInforUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(40)))));
            this.panelInforUser.Controls.Add(this.pbAvatar);
            this.panelInforUser.Controls.Add(this.btnAddAvatar);
            this.panelInforUser.Controls.Add(this.iconMininum);
            this.panelInforUser.Controls.Add(this.iconExit);
            this.panelInforUser.Controls.Add(this.ionMaxinum);
            this.panelInforUser.Controls.Add(this.cbRoleUser);
            this.panelInforUser.Controls.Add(this.cbGender);
            this.panelInforUser.Controls.Add(this.label12);
            this.panelInforUser.Controls.Add(this.txtPhone);
            this.panelInforUser.Controls.Add(this.txtPassword);
            this.panelInforUser.Controls.Add(this.txtAccount);
            this.panelInforUser.Controls.Add(this.txtEmail);
            this.panelInforUser.Controls.Add(this.label4);
            this.panelInforUser.Controls.Add(this.label10);
            this.panelInforUser.Controls.Add(this.label3);
            this.panelInforUser.Controls.Add(this.txtAddress);
            this.panelInforUser.Controls.Add(this.label2);
            this.panelInforUser.Controls.Add(this.txtFullname);
            this.panelInforUser.Controls.Add(this.label9);
            this.panelInforUser.Controls.Add(this.label1);
            this.panelInforUser.Controls.Add(this.label8);
            this.panelInforUser.Controls.Add(this.label6);
            this.panelInforUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInforUser.Location = new System.Drawing.Point(0, 0);
            this.panelInforUser.Name = "panelInforUser";
            this.panelInforUser.Size = new System.Drawing.Size(782, 450);
            this.panelInforUser.TabIndex = 40;
            this.panelInforUser.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelInforUser_MouseDown);
            // 
            // fAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 546);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelInforUser);
            this.Name = "fAddUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm người dùng";
            this.Load += new System.EventHandler(this.fAddUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMininum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ionMaxinum)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panelInforUser.ResumeLayout(false);
            this.panelInforUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pbAvatar;
        private System.Windows.Forms.Button btnAddAvatar;
        private FontAwesome.Sharp.IconPictureBox iconMininum;
        private FontAwesome.Sharp.IconPictureBox iconExit;
        private FontAwesome.Sharp.IconPictureBox ionMaxinum;
        private System.Windows.Forms.ComboBox cbRoleUser;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFullname;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelInforUser;
    }
}