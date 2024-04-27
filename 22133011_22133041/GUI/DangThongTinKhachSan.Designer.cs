﻿namespace GUI
{
    partial class DangThongTinKhachSan
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
            this.cboLoaiPhong = new System.Windows.Forms.ComboBox();
            this.txtTenKhachSan = new Guna.UI2.WinForms.Guna2TextBox();
            this.cboDiaDiem = new System.Windows.Forms.ComboBox();
            this.btnDangBai = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtMoTa = new System.Windows.Forms.RichTextBox();
            this.btnThemAnh4 = new System.Windows.Forms.Button();
            this.btnThemAnh3 = new System.Windows.Forms.Button();
            this.btnThemAnh2 = new System.Windows.Forms.Button();
            this.btnThemAnh1 = new System.Windows.Forms.Button();
            this.pictureBoxLoaiPhong = new System.Windows.Forms.PictureBox();
            this.pictureBoxDiaDiem = new System.Windows.Forms.PictureBox();
            this.pic_Anh3 = new System.Windows.Forms.PictureBox();
            this.pic_Anh2 = new System.Windows.Forms.PictureBox();
            this.pic_Anh4 = new System.Windows.Forms.PictureBox();
            this.pic_Anh1 = new System.Windows.Forms.PictureBox();
            this.lblNhapMoTa = new System.Windows.Forms.Label();
            this.btnThoat = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoaiPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDiaDiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Anh3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Anh2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Anh4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Anh1)).BeginInit();
            this.SuspendLayout();
            // 
            // cboLoaiPhong
            // 
            this.cboLoaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLoaiPhong.FormattingEnabled = true;
            this.cboLoaiPhong.Items.AddRange(new object[] {
            "Hotel",
            "Homestay"});
            this.cboLoaiPhong.Location = new System.Drawing.Point(287, 585);
            this.cboLoaiPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboLoaiPhong.Name = "cboLoaiPhong";
            this.cboLoaiPhong.Size = new System.Drawing.Size(132, 25);
            this.cboLoaiPhong.TabIndex = 125;
            // 
            // txtTenKhachSan
            // 
            this.txtTenKhachSan.BorderColor = System.Drawing.Color.Black;
            this.txtTenKhachSan.BorderThickness = 0;
            this.txtTenKhachSan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenKhachSan.DefaultText = "Vui lòng nhập tên khách sạn của bạn";
            this.txtTenKhachSan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenKhachSan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenKhachSan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenKhachSan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenKhachSan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenKhachSan.Font = new System.Drawing.Font("Segoe UI", 16.2F);
            this.txtTenKhachSan.ForeColor = System.Drawing.Color.DarkOrange;
            this.txtTenKhachSan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenKhachSan.Location = new System.Drawing.Point(12, 8);
            this.txtTenKhachSan.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtTenKhachSan.Name = "txtTenKhachSan";
            this.txtTenKhachSan.PasswordChar = '\0';
            this.txtTenKhachSan.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtTenKhachSan.PlaceholderText = "";
            this.txtTenKhachSan.SelectedText = "";
            this.txtTenKhachSan.Size = new System.Drawing.Size(839, 65);
            this.txtTenKhachSan.TabIndex = 123;
            this.txtTenKhachSan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTenKhachSan.TextChanged += new System.EventHandler(this.txtTenKhachSan_TextChanged);
            this.txtTenKhachSan.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtTenKhachSan_MouseClick);
            // 
            // cboDiaDiem
            // 
            this.cboDiaDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDiaDiem.FormattingEnabled = true;
            this.cboDiaDiem.Items.AddRange(new object[] {
            "Đà Nẵng",
            "Nha Trang",
            "Huế",
            "Khác"});
            this.cboDiaDiem.Location = new System.Drawing.Point(75, 585);
            this.cboDiaDiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboDiaDiem.Name = "cboDiaDiem";
            this.cboDiaDiem.Size = new System.Drawing.Size(132, 25);
            this.cboDiaDiem.TabIndex = 122;
            // 
            // btnDangBai
            // 
            this.btnDangBai.Animated = true;
            this.btnDangBai.BorderThickness = 1;
            this.btnDangBai.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDangBai.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDangBai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDangBai.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDangBai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDangBai.FillColor = System.Drawing.Color.White;
            this.btnDangBai.FillColor2 = System.Drawing.Color.White;
            this.btnDangBai.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btnDangBai.ForeColor = System.Drawing.Color.Black;
            this.btnDangBai.Location = new System.Drawing.Point(691, 575);
            this.btnDangBai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDangBai.Name = "btnDangBai";
            this.btnDangBai.Size = new System.Drawing.Size(100, 33);
            this.btnDangBai.TabIndex = 121;
            this.btnDangBai.Text = "Lưu";
            this.btnDangBai.Click += new System.EventHandler(this.btnDangBai_Click);
            // 
            // txtMoTa
            // 
            this.txtMoTa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoTa.Location = new System.Drawing.Point(14, 419);
            this.txtMoTa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(839, 130);
            this.txtMoTa.TabIndex = 119;
            this.txtMoTa.Text = "";
            // 
            // btnThemAnh4
            // 
            this.btnThemAnh4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThemAnh4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemAnh4.Location = new System.Drawing.Point(550, 355);
            this.btnThemAnh4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemAnh4.Name = "btnThemAnh4";
            this.btnThemAnh4.Size = new System.Drawing.Size(123, 27);
            this.btnThemAnh4.TabIndex = 118;
            this.btnThemAnh4.Text = "Thêm ảnh";
            this.btnThemAnh4.UseVisualStyleBackColor = true;
            this.btnThemAnh4.Click += new System.EventHandler(this.btnThemAnh4_Click);
            // 
            // btnThemAnh3
            // 
            this.btnThemAnh3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThemAnh3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemAnh3.Location = new System.Drawing.Point(671, 182);
            this.btnThemAnh3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemAnh3.Name = "btnThemAnh3";
            this.btnThemAnh3.Size = new System.Drawing.Size(119, 27);
            this.btnThemAnh3.TabIndex = 117;
            this.btnThemAnh3.Text = "Thêm ảnh";
            this.btnThemAnh3.UseVisualStyleBackColor = true;
            this.btnThemAnh3.Click += new System.EventHandler(this.btnThemAnh3_Click);
            // 
            // btnThemAnh2
            // 
            this.btnThemAnh2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThemAnh2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemAnh2.Location = new System.Drawing.Point(438, 182);
            this.btnThemAnh2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemAnh2.Name = "btnThemAnh2";
            this.btnThemAnh2.Size = new System.Drawing.Size(119, 27);
            this.btnThemAnh2.TabIndex = 116;
            this.btnThemAnh2.Text = "Thêm ảnh";
            this.btnThemAnh2.UseVisualStyleBackColor = true;
            this.btnThemAnh2.Click += new System.EventHandler(this.btnThemAnh2_Click);
            // 
            // btnThemAnh1
            // 
            this.btnThemAnh1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThemAnh1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemAnh1.Location = new System.Drawing.Point(124, 355);
            this.btnThemAnh1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemAnh1.Name = "btnThemAnh1";
            this.btnThemAnh1.Size = new System.Drawing.Size(123, 27);
            this.btnThemAnh1.TabIndex = 115;
            this.btnThemAnh1.Text = "Thêm ảnh";
            this.btnThemAnh1.UseVisualStyleBackColor = true;
            this.btnThemAnh1.Click += new System.EventHandler(this.btnThemAnh1_Click);
            // 
            // pictureBoxLoaiPhong
            // 
            this.pictureBoxLoaiPhong.Image = global::GUI.Properties.Resources.AnhUCKhachSan;
            this.pictureBoxLoaiPhong.Location = new System.Drawing.Point(226, 556);
            this.pictureBoxLoaiPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxLoaiPhong.Name = "pictureBoxLoaiPhong";
            this.pictureBoxLoaiPhong.Size = new System.Drawing.Size(55, 52);
            this.pictureBoxLoaiPhong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLoaiPhong.TabIndex = 124;
            this.pictureBoxLoaiPhong.TabStop = false;
            // 
            // pictureBoxDiaDiem
            // 
            this.pictureBoxDiaDiem.Image = global::GUI.Properties.Resources.iconDiaDiem;
            this.pictureBoxDiaDiem.Location = new System.Drawing.Point(14, 556);
            this.pictureBoxDiaDiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxDiaDiem.Name = "pictureBoxDiaDiem";
            this.pictureBoxDiaDiem.Size = new System.Drawing.Size(55, 52);
            this.pictureBoxDiaDiem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDiaDiem.TabIndex = 120;
            this.pictureBoxDiaDiem.TabStop = false;
            // 
            // pic_Anh3
            // 
            this.pic_Anh3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_Anh3.Location = new System.Drawing.Point(618, 75);
            this.pic_Anh3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pic_Anh3.Name = "pic_Anh3";
            this.pic_Anh3.Size = new System.Drawing.Size(235, 100);
            this.pic_Anh3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Anh3.TabIndex = 114;
            this.pic_Anh3.TabStop = false;
            // 
            // pic_Anh2
            // 
            this.pic_Anh2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_Anh2.Location = new System.Drawing.Point(390, 75);
            this.pic_Anh2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pic_Anh2.Name = "pic_Anh2";
            this.pic_Anh2.Size = new System.Drawing.Size(221, 100);
            this.pic_Anh2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Anh2.TabIndex = 113;
            this.pic_Anh2.TabStop = false;
            // 
            // pic_Anh4
            // 
            this.pic_Anh4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_Anh4.Location = new System.Drawing.Point(390, 222);
            this.pic_Anh4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pic_Anh4.Name = "pic_Anh4";
            this.pic_Anh4.Size = new System.Drawing.Size(462, 119);
            this.pic_Anh4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Anh4.TabIndex = 112;
            this.pic_Anh4.TabStop = false;
            // 
            // pic_Anh1
            // 
            this.pic_Anh1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_Anh1.Location = new System.Drawing.Point(12, 75);
            this.pic_Anh1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pic_Anh1.Name = "pic_Anh1";
            this.pic_Anh1.Size = new System.Drawing.Size(371, 265);
            this.pic_Anh1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Anh1.TabIndex = 111;
            this.pic_Anh1.TabStop = false;
            // 
            // lblNhapMoTa
            // 
            this.lblNhapMoTa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhapMoTa.Location = new System.Drawing.Point(11, 398);
            this.lblNhapMoTa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNhapMoTa.Name = "lblNhapMoTa";
            this.lblNhapMoTa.Size = new System.Drawing.Size(145, 19);
            this.lblNhapMoTa.TabIndex = 126;
            this.lblNhapMoTa.Text = "Nhập mô tả bên dưới:";
            // 
            // btnThoat
            // 
            this.btnThoat.Animated = true;
            this.btnThoat.BorderThickness = 1;
            this.btnThoat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThoat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThoat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThoat.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThoat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThoat.FillColor = System.Drawing.Color.White;
            this.btnThoat.FillColor2 = System.Drawing.Color.White;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btnThoat.ForeColor = System.Drawing.Color.Black;
            this.btnThoat.Location = new System.Drawing.Point(495, 575);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 33);
            this.btnThoat.TabIndex = 127;
            this.btnThoat.Text = "Thoát";
            // 
            // DangThongTinKhachSan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 619);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.lblNhapMoTa);
            this.Controls.Add(this.cboLoaiPhong);
            this.Controls.Add(this.pictureBoxLoaiPhong);
            this.Controls.Add(this.txtTenKhachSan);
            this.Controls.Add(this.cboDiaDiem);
            this.Controls.Add(this.btnDangBai);
            this.Controls.Add(this.pictureBoxDiaDiem);
            this.Controls.Add(this.txtMoTa);
            this.Controls.Add(this.btnThemAnh4);
            this.Controls.Add(this.btnThemAnh3);
            this.Controls.Add(this.btnThemAnh2);
            this.Controls.Add(this.btnThemAnh1);
            this.Controls.Add(this.pic_Anh3);
            this.Controls.Add(this.pic_Anh2);
            this.Controls.Add(this.pic_Anh4);
            this.Controls.Add(this.pic_Anh1);
            this.Name = "DangThongTinKhachSan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DangThongTinKhachSan";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoaiPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDiaDiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Anh3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Anh2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Anh4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Anh1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ComboBox cboLoaiPhong;
        public System.Windows.Forms.PictureBox pictureBoxLoaiPhong;
        public Guna.UI2.WinForms.Guna2TextBox txtTenKhachSan;
        public System.Windows.Forms.ComboBox cboDiaDiem;
        public Guna.UI2.WinForms.Guna2GradientButton btnDangBai;
        public System.Windows.Forms.PictureBox pictureBoxDiaDiem;
        public System.Windows.Forms.RichTextBox txtMoTa;
        public System.Windows.Forms.Button btnThemAnh4;
        public System.Windows.Forms.Button btnThemAnh3;
        public System.Windows.Forms.Button btnThemAnh2;
        public System.Windows.Forms.Button btnThemAnh1;
        public System.Windows.Forms.PictureBox pic_Anh3;
        public System.Windows.Forms.PictureBox pic_Anh2;
        public System.Windows.Forms.PictureBox pic_Anh4;
        public System.Windows.Forms.PictureBox pic_Anh1;
        private System.Windows.Forms.Label lblNhapMoTa;
        public Guna.UI2.WinForms.Guna2GradientButton btnThoat;
    }
}