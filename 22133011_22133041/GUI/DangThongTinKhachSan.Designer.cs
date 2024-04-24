namespace GUI
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
            this.cboLoaiPhong.Location = new System.Drawing.Point(368, 709);
            this.cboLoaiPhong.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cboLoaiPhong.Name = "cboLoaiPhong";
            this.cboLoaiPhong.Size = new System.Drawing.Size(175, 28);
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
            this.txtTenKhachSan.ForeColor = System.Drawing.Color.Black;
            this.txtTenKhachSan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenKhachSan.Location = new System.Drawing.Point(1, -1);
            this.txtTenKhachSan.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.txtTenKhachSan.Name = "txtTenKhachSan";
            this.txtTenKhachSan.PasswordChar = '\0';
            this.txtTenKhachSan.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtTenKhachSan.PlaceholderText = "";
            this.txtTenKhachSan.SelectedText = "";
            this.txtTenKhachSan.Size = new System.Drawing.Size(1119, 80);
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
            this.cboDiaDiem.Location = new System.Drawing.Point(85, 709);
            this.cboDiaDiem.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cboDiaDiem.Name = "cboDiaDiem";
            this.cboDiaDiem.Size = new System.Drawing.Size(175, 28);
            this.cboDiaDiem.TabIndex = 122;
            // 
            // btnDangBai
            // 
            this.btnDangBai.Animated = true;
            this.btnDangBai.AutoRoundedCorners = true;
            this.btnDangBai.BorderRadius = 27;
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
            this.btnDangBai.Location = new System.Drawing.Point(719, 687);
            this.btnDangBai.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnDangBai.Name = "btnDangBai";
            this.btnDangBai.Size = new System.Drawing.Size(240, 57);
            this.btnDangBai.TabIndex = 121;
            this.btnDangBai.Text = "Lưu";
            this.btnDangBai.Click += new System.EventHandler(this.btnDangBai_Click);
            // 
            // txtMoTa
            // 
            this.txtMoTa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoTa.Location = new System.Drawing.Point(4, 505);
            this.txtMoTa.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(1117, 159);
            this.txtMoTa.TabIndex = 119;
            this.txtMoTa.Text = "";
            // 
            // btnThemAnh4
            // 
            this.btnThemAnh4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThemAnh4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemAnh4.Location = new System.Drawing.Point(719, 426);
            this.btnThemAnh4.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnThemAnh4.Name = "btnThemAnh4";
            this.btnThemAnh4.Size = new System.Drawing.Size(164, 42);
            this.btnThemAnh4.TabIndex = 118;
            this.btnThemAnh4.Text = "Thêm ảnh";
            this.btnThemAnh4.UseVisualStyleBackColor = true;
            this.btnThemAnh4.Click += new System.EventHandler(this.btnThemAnh4_Click);
            // 
            // btnThemAnh3
            // 
            this.btnThemAnh3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThemAnh3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemAnh3.Location = new System.Drawing.Point(880, 213);
            this.btnThemAnh3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnThemAnh3.Name = "btnThemAnh3";
            this.btnThemAnh3.Size = new System.Drawing.Size(159, 42);
            this.btnThemAnh3.TabIndex = 117;
            this.btnThemAnh3.Text = "Thêm ảnh";
            this.btnThemAnh3.UseVisualStyleBackColor = true;
            this.btnThemAnh3.Click += new System.EventHandler(this.btnThemAnh3_Click);
            // 
            // btnThemAnh2
            // 
            this.btnThemAnh2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThemAnh2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemAnh2.Location = new System.Drawing.Point(569, 213);
            this.btnThemAnh2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnThemAnh2.Name = "btnThemAnh2";
            this.btnThemAnh2.Size = new System.Drawing.Size(159, 42);
            this.btnThemAnh2.TabIndex = 116;
            this.btnThemAnh2.Text = "Thêm ảnh";
            this.btnThemAnh2.UseVisualStyleBackColor = true;
            this.btnThemAnh2.Click += new System.EventHandler(this.btnThemAnh2_Click);
            // 
            // btnThemAnh1
            // 
            this.btnThemAnh1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThemAnh1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemAnh1.Location = new System.Drawing.Point(151, 426);
            this.btnThemAnh1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnThemAnh1.Name = "btnThemAnh1";
            this.btnThemAnh1.Size = new System.Drawing.Size(164, 42);
            this.btnThemAnh1.TabIndex = 115;
            this.btnThemAnh1.Text = "Thêm ảnh";
            this.btnThemAnh1.UseVisualStyleBackColor = true;
            this.btnThemAnh1.Click += new System.EventHandler(this.btnThemAnh1_Click);
            // 
            // pictureBoxLoaiPhong
            // 
            this.pictureBoxLoaiPhong.Image = global::GUI.Properties.Resources.AnhUCKhachSan;
            this.pictureBoxLoaiPhong.Location = new System.Drawing.Point(287, 679);
            this.pictureBoxLoaiPhong.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pictureBoxLoaiPhong.Name = "pictureBoxLoaiPhong";
            this.pictureBoxLoaiPhong.Size = new System.Drawing.Size(73, 64);
            this.pictureBoxLoaiPhong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLoaiPhong.TabIndex = 124;
            this.pictureBoxLoaiPhong.TabStop = false;
            // 
            // pictureBoxDiaDiem
            // 
            this.pictureBoxDiaDiem.Image = global::GUI.Properties.Resources.iconDiaDiem;
            this.pictureBoxDiaDiem.Location = new System.Drawing.Point(4, 679);
            this.pictureBoxDiaDiem.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pictureBoxDiaDiem.Name = "pictureBoxDiaDiem";
            this.pictureBoxDiaDiem.Size = new System.Drawing.Size(73, 64);
            this.pictureBoxDiaDiem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDiaDiem.TabIndex = 120;
            this.pictureBoxDiaDiem.TabStop = false;
            // 
            // pic_Anh3
            // 
            this.pic_Anh3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_Anh3.Location = new System.Drawing.Point(809, 81);
            this.pic_Anh3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pic_Anh3.Name = "pic_Anh3";
            this.pic_Anh3.Size = new System.Drawing.Size(313, 123);
            this.pic_Anh3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Anh3.TabIndex = 114;
            this.pic_Anh3.TabStop = false;
            // 
            // pic_Anh2
            // 
            this.pic_Anh2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_Anh2.Location = new System.Drawing.Point(505, 81);
            this.pic_Anh2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pic_Anh2.Name = "pic_Anh2";
            this.pic_Anh2.Size = new System.Drawing.Size(294, 123);
            this.pic_Anh2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Anh2.TabIndex = 113;
            this.pic_Anh2.TabStop = false;
            // 
            // pic_Anh4
            // 
            this.pic_Anh4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_Anh4.Location = new System.Drawing.Point(505, 262);
            this.pic_Anh4.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pic_Anh4.Name = "pic_Anh4";
            this.pic_Anh4.Size = new System.Drawing.Size(615, 146);
            this.pic_Anh4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Anh4.TabIndex = 112;
            this.pic_Anh4.TabStop = false;
            // 
            // pic_Anh1
            // 
            this.pic_Anh1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_Anh1.Location = new System.Drawing.Point(1, 81);
            this.pic_Anh1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pic_Anh1.Name = "pic_Anh1";
            this.pic_Anh1.Size = new System.Drawing.Size(494, 326);
            this.pic_Anh1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Anh1.TabIndex = 111;
            this.pic_Anh1.TabStop = false;
            // 
            // lblNhapMoTa
            // 
            this.lblNhapMoTa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhapMoTa.Location = new System.Drawing.Point(12, 480);
            this.lblNhapMoTa.Name = "lblNhapMoTa";
            this.lblNhapMoTa.Size = new System.Drawing.Size(169, 23);
            this.lblNhapMoTa.TabIndex = 126;
            this.lblNhapMoTa.Text = "Nhập mô tả bên dưới";
            // 
            // DangThongTinKhachSan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 758);
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
            this.Margin = new System.Windows.Forms.Padding(4);
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
    }
}