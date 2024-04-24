namespace GUI
{
    partial class TrangChuUser
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
            this.flpTrangChuUser = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlTrangChu = new System.Windows.Forms.Panel();
            this.btnLichSuBook = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.pic_DangXuat = new System.Windows.Forms.PictureBox();
            this.pic_AnhDaiDien = new System.Windows.Forms.PictureBox();
            this.lblTenTaiKhoan = new System.Windows.Forms.Label();
            this.btnTimKiem = new Guna.UI2.WinForms.Guna2GradientButton();
            this.cboDiaDiemTimKiem = new System.Windows.Forms.ComboBox();
            this.lblTenTrangChu = new System.Windows.Forms.Label();
            this.pnlTrangChu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_DangXuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_AnhDaiDien)).BeginInit();
            this.SuspendLayout();
            // 
            // flpTrangChuUser
            // 
            this.flpTrangChuUser.AutoScroll = true;
            this.flpTrangChuUser.Location = new System.Drawing.Point(3, 125);
            this.flpTrangChuUser.Margin = new System.Windows.Forms.Padding(2);
            this.flpTrangChuUser.Name = "flpTrangChuUser";
            this.flpTrangChuUser.Size = new System.Drawing.Size(1088, 359);
            this.flpTrangChuUser.TabIndex = 11;
            // 
            // pnlTrangChu
            // 
            this.pnlTrangChu.Controls.Add(this.btnLichSuBook);
            this.pnlTrangChu.Controls.Add(this.guna2Separator1);
            this.pnlTrangChu.Controls.Add(this.pic_DangXuat);
            this.pnlTrangChu.Controls.Add(this.pic_AnhDaiDien);
            this.pnlTrangChu.Controls.Add(this.lblTenTaiKhoan);
            this.pnlTrangChu.Controls.Add(this.btnTimKiem);
            this.pnlTrangChu.Controls.Add(this.cboDiaDiemTimKiem);
            this.pnlTrangChu.Controls.Add(this.lblTenTrangChu);
            this.pnlTrangChu.Location = new System.Drawing.Point(3, 1);
            this.pnlTrangChu.Margin = new System.Windows.Forms.Padding(2);
            this.pnlTrangChu.Name = "pnlTrangChu";
            this.pnlTrangChu.Size = new System.Drawing.Size(1088, 119);
            this.pnlTrangChu.TabIndex = 10;
            // 
            // btnLichSuBook
            // 
            this.btnLichSuBook.Animated = true;
            this.btnLichSuBook.AutoRoundedCorners = true;
            this.btnLichSuBook.BackColor = System.Drawing.Color.Transparent;
            this.btnLichSuBook.BorderColor = System.Drawing.Color.White;
            this.btnLichSuBook.BorderRadius = 15;
            this.btnLichSuBook.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLichSuBook.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLichSuBook.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLichSuBook.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLichSuBook.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLichSuBook.FillColor = System.Drawing.Color.Orange;
            this.btnLichSuBook.FillColor2 = System.Drawing.Color.PeachPuff;
            this.btnLichSuBook.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btnLichSuBook.ForeColor = System.Drawing.Color.Black;
            this.btnLichSuBook.Location = new System.Drawing.Point(784, 10);
            this.btnLichSuBook.Margin = new System.Windows.Forms.Padding(2);
            this.btnLichSuBook.Name = "btnLichSuBook";
            this.btnLichSuBook.Size = new System.Drawing.Size(127, 32);
            this.btnLichSuBook.TabIndex = 30;
            this.btnLichSuBook.Text = "Lịch Sử Book";
            this.btnLichSuBook.Click += new System.EventHandler(this.btnLichSuBook_Click);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Separator1.FillColor = System.Drawing.Color.DarkOrange;
            this.guna2Separator1.Location = new System.Drawing.Point(48, 107);
            this.guna2Separator1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(963, 8);
            this.guna2Separator1.TabIndex = 27;
            // 
            // pic_DangXuat
            // 
            this.pic_DangXuat.BackColor = System.Drawing.Color.Transparent;
            this.pic_DangXuat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_DangXuat.Image = global::GUI.Properties.Resources.icons8_logout;
            this.pic_DangXuat.Location = new System.Drawing.Point(1041, 41);
            this.pic_DangXuat.Margin = new System.Windows.Forms.Padding(2);
            this.pic_DangXuat.Name = "pic_DangXuat";
            this.pic_DangXuat.Size = new System.Drawing.Size(30, 32);
            this.pic_DangXuat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_DangXuat.TabIndex = 29;
            this.pic_DangXuat.TabStop = false;
            this.pic_DangXuat.Click += new System.EventHandler(this.pic_DangXuat_Click);
            // 
            // pic_AnhDaiDien
            // 
            this.pic_AnhDaiDien.BackColor = System.Drawing.Color.Transparent;
            this.pic_AnhDaiDien.Image = global::GUI.Properties.Resources._8;
            this.pic_AnhDaiDien.Location = new System.Drawing.Point(950, 6);
            this.pic_AnhDaiDien.Name = "pic_AnhDaiDien";
            this.pic_AnhDaiDien.Size = new System.Drawing.Size(68, 64);
            this.pic_AnhDaiDien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_AnhDaiDien.TabIndex = 28;
            this.pic_AnhDaiDien.TabStop = false;
            // 
            // lblTenTaiKhoan
            // 
            this.lblTenTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenTaiKhoan.Location = new System.Drawing.Point(916, 75);
            this.lblTenTaiKhoan.Name = "lblTenTaiKhoan";
            this.lblTenTaiKhoan.Size = new System.Drawing.Size(142, 30);
            this.lblTenTaiKhoan.TabIndex = 26;
            this.lblTenTaiKhoan.Text = "Tên Tài Khoản";
            this.lblTenTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Animated = true;
            this.btnTimKiem.AutoRoundedCorners = true;
            this.btnTimKiem.BackColor = System.Drawing.Color.Transparent;
            this.btnTimKiem.BorderColor = System.Drawing.Color.White;
            this.btnTimKiem.BorderRadius = 15;
            this.btnTimKiem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTimKiem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTimKiem.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTimKiem.FillColor = System.Drawing.Color.Orange;
            this.btnTimKiem.FillColor2 = System.Drawing.Color.PeachPuff;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btnTimKiem.ForeColor = System.Drawing.Color.Black;
            this.btnTimKiem.Location = new System.Drawing.Point(784, 62);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(127, 32);
            this.btnTimKiem.TabIndex = 20;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // cboDiaDiemTimKiem
            // 
            this.cboDiaDiemTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cboDiaDiemTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDiaDiemTimKiem.FormattingEnabled = true;
            this.cboDiaDiemTimKiem.Items.AddRange(new object[] {
            "Huế",
            "Đà Nẵng",
            "Nha Trang",
            "Khác"});
            this.cboDiaDiemTimKiem.Location = new System.Drawing.Point(215, 41);
            this.cboDiaDiemTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.cboDiaDiemTimKiem.Name = "cboDiaDiemTimKiem";
            this.cboDiaDiemTimKiem.Size = new System.Drawing.Size(551, 34);
            this.cboDiaDiemTimKiem.TabIndex = 16;
            // 
            // lblTenTrangChu
            // 
            this.lblTenTrangChu.AutoSize = true;
            this.lblTenTrangChu.BackColor = System.Drawing.Color.Transparent;
            this.lblTenTrangChu.Font = new System.Drawing.Font("NSimSun", 40.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenTrangChu.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblTenTrangChu.Location = new System.Drawing.Point(20, 26);
            this.lblTenTrangChu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenTrangChu.Name = "lblTenTrangChu";
            this.lblTenTrangChu.Size = new System.Drawing.Size(191, 54);
            this.lblTenTrangChu.TabIndex = 15;
            this.lblTenTrangChu.Text = "Travel\r\n";
            this.lblTenTrangChu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TrangChuUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 488);
            this.Controls.Add(this.flpTrangChuUser);
            this.Controls.Add(this.pnlTrangChu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TrangChuUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrangChuUser";
            this.Load += new System.EventHandler(this.TrangChuUser_Load);
            this.pnlTrangChu.ResumeLayout(false);
            this.pnlTrangChu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_DangXuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_AnhDaiDien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.FlowLayoutPanel flpTrangChuUser;
        public System.Windows.Forms.Panel pnlTrangChu;
        public Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        public System.Windows.Forms.PictureBox pic_DangXuat;
        public System.Windows.Forms.PictureBox pic_AnhDaiDien;
        public System.Windows.Forms.Label lblTenTaiKhoan;
        public Guna.UI2.WinForms.Guna2GradientButton btnTimKiem;
        public System.Windows.Forms.ComboBox cboDiaDiemTimKiem;
        public System.Windows.Forms.Label lblTenTrangChu;
        public Guna.UI2.WinForms.Guna2GradientButton btnLichSuBook;
    }
}