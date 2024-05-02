namespace GUI
{
    partial class UCThongTinKhachSanUser
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDiaDiemKhachSan = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTenKhachSan = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblGiaTien = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblGia = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pic_Anh = new System.Windows.Forms.PictureBox();
            this.linklblDiemDanhGia = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Anh)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDiaDiemKhachSan
            // 
            this.lblDiaDiemKhachSan.BackColor = System.Drawing.Color.Transparent;
            this.lblDiaDiemKhachSan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaDiemKhachSan.Location = new System.Drawing.Point(180, 50);
            this.lblDiaDiemKhachSan.Margin = new System.Windows.Forms.Padding(2);
            this.lblDiaDiemKhachSan.Name = "lblDiaDiemKhachSan";
            this.lblDiaDiemKhachSan.Size = new System.Drawing.Size(77, 22);
            this.lblDiaDiemKhachSan.TabIndex = 2;
            this.lblDiaDiemKhachSan.Text = "Nha Trang";
            // 
            // lblTenKhachSan
            // 
            this.lblTenKhachSan.BackColor = System.Drawing.Color.Transparent;
            this.lblTenKhachSan.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenKhachSan.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblTenKhachSan.Location = new System.Drawing.Point(180, 2);
            this.lblTenKhachSan.Margin = new System.Windows.Forms.Padding(2);
            this.lblTenKhachSan.Name = "lblTenKhachSan";
            this.lblTenKhachSan.Size = new System.Drawing.Size(167, 31);
            this.lblTenKhachSan.TabIndex = 1;
            this.lblTenKhachSan.Text = "Tên Khách Sạn";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblGiaTien);
            this.panel1.Controls.Add(this.lblGia);
            this.panel1.Controls.Add(this.pic_Anh);
            this.panel1.Controls.Add(this.lblTenKhachSan);
            this.panel1.Controls.Add(this.lblDiaDiemKhachSan);
            this.panel1.Controls.Add(this.linklblDiemDanhGia);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(523, 188);
            this.panel1.TabIndex = 6;
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // lblGiaTien
            // 
            this.lblGiaTien.AutoSize = false;
            this.lblGiaTien.BackColor = System.Drawing.Color.Transparent;
            this.lblGiaTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaTien.Location = new System.Drawing.Point(388, 160);
            this.lblGiaTien.Margin = new System.Windows.Forms.Padding(2);
            this.lblGiaTien.Name = "lblGiaTien";
            this.lblGiaTien.Size = new System.Drawing.Size(114, 23);
            this.lblGiaTien.TabIndex = 7;
            this.lblGiaTien.Text = "1,500,000 VND";
            // 
            // lblGia
            // 
            this.lblGia.AutoSize = false;
            this.lblGia.BackColor = System.Drawing.Color.Transparent;
            this.lblGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGia.Location = new System.Drawing.Point(368, 129);
            this.lblGia.Margin = new System.Windows.Forms.Padding(2);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(672, 27);
            this.lblGia.TabIndex = 7;
            this.lblGia.Text = "Giá trung bình mỗi đêm";
            // 
            // pic_Anh
            // 
            this.pic_Anh.BackColor = System.Drawing.Color.White;
            this.pic_Anh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_Anh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_Anh.Image = global::GUI.Properties.Resources.AnhUCKhachSan;
            this.pic_Anh.Location = new System.Drawing.Point(-3, -1);
            this.pic_Anh.Margin = new System.Windows.Forms.Padding(2);
            this.pic_Anh.Name = "pic_Anh";
            this.pic_Anh.Size = new System.Drawing.Size(179, 188);
            this.pic_Anh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Anh.TabIndex = 0;
            this.pic_Anh.TabStop = false;
            // 
            // linklblDiemDanhGia
            // 
            this.linklblDiemDanhGia.AutoSize = true;
            this.linklblDiemDanhGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklblDiemDanhGia.LinkColor = System.Drawing.Color.Black;
            this.linklblDiemDanhGia.Location = new System.Drawing.Point(472, 2);
            this.linklblDiemDanhGia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linklblDiemDanhGia.Name = "linklblDiemDanhGia";
            this.linklblDiemDanhGia.Size = new System.Drawing.Size(42, 26);
            this.linklblDiemDanhGia.TabIndex = 5;
            this.linklblDiemDanhGia.TabStop = true;
            this.linklblDiemDanhGia.Text = "9,0";
            // 
            // UCThongTinKhachSanUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UCThongTinKhachSanUser";
            this.Size = new System.Drawing.Size(527, 190);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Anh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.PictureBox pic_Anh;
        public Guna.UI2.WinForms.Guna2HtmlLabel lblTenKhachSan;
        public Guna.UI2.WinForms.Guna2HtmlLabel lblDiaDiemKhachSan;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.LinkLabel linklblDiemDanhGia;
        public Guna.UI2.WinForms.Guna2HtmlLabel lblGiaTien;
        public Guna.UI2.WinForms.Guna2HtmlLabel lblGia;
    }
}
