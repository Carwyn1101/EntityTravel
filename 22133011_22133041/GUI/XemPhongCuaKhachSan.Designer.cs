namespace GUI
{
    partial class XemPhongCuaKhachSan
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
            this.pnlTienDe = new System.Windows.Forms.Panel();
            this.btnTimKiem = new System.Windows.Forms.PictureBox();
            this.lblNgayTraPhong = new System.Windows.Forms.Label();
            this.lblNgayNhanPhong = new System.Windows.Forms.Label();
            this.dtpNgayTraPhong = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpNgayNhanPhong = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cboLoaiPhong = new System.Windows.Forms.ComboBox();
            this.lblLoaiPhong = new System.Windows.Forms.Label();
            this.lblPhong = new System.Windows.Forms.Label();
            this.flpTrangChuKhachSan = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlTienDe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnTimKiem)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTienDe
            // 
            this.pnlTienDe.Controls.Add(this.btnTimKiem);
            this.pnlTienDe.Controls.Add(this.lblNgayTraPhong);
            this.pnlTienDe.Controls.Add(this.lblNgayNhanPhong);
            this.pnlTienDe.Controls.Add(this.dtpNgayTraPhong);
            this.pnlTienDe.Controls.Add(this.dtpNgayNhanPhong);
            this.pnlTienDe.Controls.Add(this.cboLoaiPhong);
            this.pnlTienDe.Controls.Add(this.lblLoaiPhong);
            this.pnlTienDe.Controls.Add(this.lblPhong);
            this.pnlTienDe.Location = new System.Drawing.Point(3, 1);
            this.pnlTienDe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlTienDe.Name = "pnlTienDe";
            this.pnlTienDe.Size = new System.Drawing.Size(795, 145);
            this.pnlTienDe.TabIndex = 6;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.Transparent;
            this.btnTimKiem.Image = global::GUI.Properties.Resources.search;
            this.btnTimKiem.Location = new System.Drawing.Point(721, 80);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(39, 32);
            this.btnTimKiem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnTimKiem.TabIndex = 17;
            this.btnTimKiem.TabStop = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // lblNgayTraPhong
            // 
            this.lblNgayTraPhong.AutoSize = true;
            this.lblNgayTraPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayTraPhong.Location = new System.Drawing.Point(463, 54);
            this.lblNgayTraPhong.Name = "lblNgayTraPhong";
            this.lblNgayTraPhong.Size = new System.Drawing.Size(129, 20);
            this.lblNgayTraPhong.TabIndex = 16;
            this.lblNgayTraPhong.Text = "Ngày Trả Phòng";
            // 
            // lblNgayNhanPhong
            // 
            this.lblNgayNhanPhong.AutoSize = true;
            this.lblNgayNhanPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayNhanPhong.Location = new System.Drawing.Point(221, 54);
            this.lblNgayNhanPhong.Name = "lblNgayNhanPhong";
            this.lblNgayNhanPhong.Size = new System.Drawing.Size(143, 20);
            this.lblNgayNhanPhong.TabIndex = 15;
            this.lblNgayNhanPhong.Text = "Ngày Nhận Phòng";
            // 
            // dtpNgayTraPhong
            // 
            this.dtpNgayTraPhong.Checked = true;
            this.dtpNgayTraPhong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgayTraPhong.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpNgayTraPhong.Location = new System.Drawing.Point(467, 84);
            this.dtpNgayTraPhong.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgayTraPhong.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgayTraPhong.Name = "dtpNgayTraPhong";
            this.dtpNgayTraPhong.Size = new System.Drawing.Size(221, 28);
            this.dtpNgayTraPhong.TabIndex = 14;
            this.dtpNgayTraPhong.Value = new System.DateTime(2024, 4, 28, 14, 2, 53, 395);
            // 
            // dtpNgayNhanPhong
            // 
            this.dtpNgayNhanPhong.Checked = true;
            this.dtpNgayNhanPhong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgayNhanPhong.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpNgayNhanPhong.Location = new System.Drawing.Point(225, 84);
            this.dtpNgayNhanPhong.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgayNhanPhong.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgayNhanPhong.Name = "dtpNgayNhanPhong";
            this.dtpNgayNhanPhong.Size = new System.Drawing.Size(221, 28);
            this.dtpNgayNhanPhong.TabIndex = 13;
            this.dtpNgayNhanPhong.Value = new System.DateTime(2024, 4, 28, 14, 2, 53, 395);
            // 
            // cboLoaiPhong
            // 
            this.cboLoaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLoaiPhong.FormattingEnabled = true;
            this.cboLoaiPhong.Items.AddRange(new object[] {
            "Phòng giường đôi",
            "Phòng giường đơn",
            "Phòng 2 giường đơn",
            "Phòng 2 giường đôi",
            "Khác"});
            this.cboLoaiPhong.Location = new System.Drawing.Point(17, 84);
            this.cboLoaiPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboLoaiPhong.Name = "cboLoaiPhong";
            this.cboLoaiPhong.Size = new System.Drawing.Size(188, 28);
            this.cboLoaiPhong.TabIndex = 11;
            // 
            // lblLoaiPhong
            // 
            this.lblLoaiPhong.AutoSize = true;
            this.lblLoaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaiPhong.Location = new System.Drawing.Point(12, 54);
            this.lblLoaiPhong.Name = "lblLoaiPhong";
            this.lblLoaiPhong.Size = new System.Drawing.Size(93, 20);
            this.lblLoaiPhong.TabIndex = 8;
            this.lblLoaiPhong.Text = "Loại Phòng";
            // 
            // lblPhong
            // 
            this.lblPhong.AutoSize = true;
            this.lblPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhong.Location = new System.Drawing.Point(11, 6);
            this.lblPhong.Name = "lblPhong";
            this.lblPhong.Size = new System.Drawing.Size(169, 32);
            this.lblPhong.TabIndex = 0;
            this.lblPhong.Text = "Phòng trống";
            // 
            // flpTrangChuKhachSan
            // 
            this.flpTrangChuKhachSan.AutoScroll = true;
            this.flpTrangChuKhachSan.Location = new System.Drawing.Point(3, 150);
            this.flpTrangChuKhachSan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flpTrangChuKhachSan.Name = "flpTrangChuKhachSan";
            this.flpTrangChuKhachSan.Size = new System.Drawing.Size(795, 605);
            this.flpTrangChuKhachSan.TabIndex = 7;
            // 
            // XemPhongCuaKhachSan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 759);
            this.Controls.Add(this.pnlTienDe);
            this.Controls.Add(this.flpTrangChuKhachSan);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "XemPhongCuaKhachSan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XemPhongCuaKhachSan";
            this.pnlTienDe.ResumeLayout(false);
            this.pnlTienDe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnTimKiem)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Panel pnlTienDe;
        private System.Windows.Forms.ComboBox cboLoaiPhong;
        private System.Windows.Forms.Label lblLoaiPhong;
        private System.Windows.Forms.Label lblPhong;
        private System.Windows.Forms.FlowLayoutPanel flpTrangChuKhachSan;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgayNhanPhong;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgayTraPhong;
        private System.Windows.Forms.Label lblNgayTraPhong;
        private System.Windows.Forms.Label lblNgayNhanPhong;
        private System.Windows.Forms.PictureBox btnTimKiem;
    }
}