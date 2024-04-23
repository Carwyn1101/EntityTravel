namespace GUI
{
    partial class ChiTietKhachHang
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
            this.lblThongTinLienLac = new System.Windows.Forms.Label();
            this.btnThanhToan = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lblTongTien = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblHoVaTen = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblSoDienThoai = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblCCCD = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblMail = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblNgayNhanPhong = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblNgayTraPhong = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtTenKhachHang = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCCCD = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSoDienThoai = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTongTienThanhToan = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtpNgayNhanPhong = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpNgayTraPhong = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.SuspendLayout();
            // 
            // lblThongTinLienLac
            // 
            this.lblThongTinLienLac.AutoSize = true;
            this.lblThongTinLienLac.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTinLienLac.Location = new System.Drawing.Point(6, -1);
            this.lblThongTinLienLac.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblThongTinLienLac.Name = "lblThongTinLienLac";
            this.lblThongTinLienLac.Size = new System.Drawing.Size(236, 33);
            this.lblThongTinLienLac.TabIndex = 31;
            this.lblThongTinLienLac.Text = "Thông tin liên lạc";
            this.lblThongTinLienLac.UseWaitCursor = true;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.AutoRoundedCorners = true;
            this.btnThanhToan.BorderRadius = 17;
            this.btnThanhToan.BorderThickness = 1;
            this.btnThanhToan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThanhToan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThanhToan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThanhToan.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThanhToan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThanhToan.FillColor = System.Drawing.Color.White;
            this.btnThanhToan.FillColor2 = System.Drawing.Color.White;
            this.btnThanhToan.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btnThanhToan.ForeColor = System.Drawing.Color.Black;
            this.btnThanhToan.Location = new System.Drawing.Point(344, 310);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(135, 36);
            this.btnThanhToan.TabIndex = 259;
            this.btnThanhToan.Text = "Thanh Toán";
            // 
            // lblTongTien
            // 
            this.lblTongTien.BackColor = System.Drawing.Color.Transparent;
            this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.Location = new System.Drawing.Point(12, 281);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(205, 22);
            this.lblTongTien.TabIndex = 261;
            this.lblTongTien.Text = "Tổng số tiền cần thanh toán:";
            // 
            // lblHoVaTen
            // 
            this.lblHoVaTen.BackColor = System.Drawing.Color.Transparent;
            this.lblHoVaTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoVaTen.Location = new System.Drawing.Point(12, 52);
            this.lblHoVaTen.Name = "lblHoVaTen";
            this.lblHoVaTen.Size = new System.Drawing.Size(75, 22);
            this.lblHoVaTen.TabIndex = 262;
            this.lblHoVaTen.Text = "Họ và tên:";
            // 
            // lblSoDienThoai
            // 
            this.lblSoDienThoai.BackColor = System.Drawing.Color.Transparent;
            this.lblSoDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoDienThoai.Location = new System.Drawing.Point(305, 52);
            this.lblSoDienThoai.Name = "lblSoDienThoai";
            this.lblSoDienThoai.Size = new System.Drawing.Size(100, 22);
            this.lblSoDienThoai.TabIndex = 263;
            this.lblSoDienThoai.Text = "Số điện thoại:";
            // 
            // lblCCCD
            // 
            this.lblCCCD.BackColor = System.Drawing.Color.Transparent;
            this.lblCCCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCCCD.Location = new System.Drawing.Point(12, 124);
            this.lblCCCD.Name = "lblCCCD";
            this.lblCCCD.Size = new System.Drawing.Size(52, 22);
            this.lblCCCD.TabIndex = 264;
            this.lblCCCD.Text = "CCCD:";
            // 
            // lblMail
            // 
            this.lblMail.BackColor = System.Drawing.Color.Transparent;
            this.lblMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.Location = new System.Drawing.Point(306, 122);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(35, 22);
            this.lblMail.TabIndex = 265;
            this.lblMail.Text = "Mail:";
            // 
            // lblNgayNhanPhong
            // 
            this.lblNgayNhanPhong.BackColor = System.Drawing.Color.Transparent;
            this.lblNgayNhanPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayNhanPhong.Location = new System.Drawing.Point(12, 199);
            this.lblNgayNhanPhong.Name = "lblNgayNhanPhong";
            this.lblNgayNhanPhong.Size = new System.Drawing.Size(132, 22);
            this.lblNgayNhanPhong.TabIndex = 266;
            this.lblNgayNhanPhong.Text = "Ngày nhận phòng:";
            // 
            // lblNgayTraPhong
            // 
            this.lblNgayTraPhong.BackColor = System.Drawing.Color.Transparent;
            this.lblNgayTraPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayTraPhong.Location = new System.Drawing.Point(306, 199);
            this.lblNgayTraPhong.Name = "lblNgayTraPhong";
            this.lblNgayTraPhong.Size = new System.Drawing.Size(115, 22);
            this.lblNgayTraPhong.TabIndex = 267;
            this.lblNgayTraPhong.Text = "Ngày trả phòng:";
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenKhachHang.DefaultText = "";
            this.txtTenKhachHang.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenKhachHang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenKhachHang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenKhachHang.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenKhachHang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenKhachHang.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKhachHang.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenKhachHang.Location = new System.Drawing.Point(12, 80);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.PasswordChar = '\0';
            this.txtTenKhachHang.PlaceholderText = "";
            this.txtTenKhachHang.SelectedText = "";
            this.txtTenKhachHang.Size = new System.Drawing.Size(234, 26);
            this.txtTenKhachHang.TabIndex = 270;
            // 
            // txtCCCD
            // 
            this.txtCCCD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCCCD.DefaultText = "";
            this.txtCCCD.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCCCD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCCCD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCCCD.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCCCD.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCCCD.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCCCD.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCCCD.Location = new System.Drawing.Point(12, 152);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.PasswordChar = '\0';
            this.txtCCCD.PlaceholderText = "";
            this.txtCCCD.SelectedText = "";
            this.txtCCCD.Size = new System.Drawing.Size(234, 26);
            this.txtCCCD.TabIndex = 271;
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoDienThoai.DefaultText = "";
            this.txtSoDienThoai.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSoDienThoai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSoDienThoai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoDienThoai.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoDienThoai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoDienThoai.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoDienThoai.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoDienThoai.Location = new System.Drawing.Point(305, 80);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.PasswordChar = '\0';
            this.txtSoDienThoai.PlaceholderText = "";
            this.txtSoDienThoai.SelectedText = "";
            this.txtSoDienThoai.Size = new System.Drawing.Size(236, 26);
            this.txtSoDienThoai.TabIndex = 272;
            // 
            // txtMail
            // 
            this.txtMail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMail.DefaultText = "";
            this.txtMail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMail.Location = new System.Drawing.Point(306, 150);
            this.txtMail.Name = "txtMail";
            this.txtMail.PasswordChar = '\0';
            this.txtMail.PlaceholderText = "";
            this.txtMail.SelectedText = "";
            this.txtMail.Size = new System.Drawing.Size(235, 26);
            this.txtMail.TabIndex = 274;
            // 
            // txtTongTienThanhToan
            // 
            this.txtTongTienThanhToan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTongTienThanhToan.DefaultText = "";
            this.txtTongTienThanhToan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTongTienThanhToan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTongTienThanhToan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTongTienThanhToan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTongTienThanhToan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTongTienThanhToan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTienThanhToan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTongTienThanhToan.Location = new System.Drawing.Point(12, 320);
            this.txtTongTienThanhToan.Name = "txtTongTienThanhToan";
            this.txtTongTienThanhToan.PasswordChar = '\0';
            this.txtTongTienThanhToan.PlaceholderText = "";
            this.txtTongTienThanhToan.SelectedText = "";
            this.txtTongTienThanhToan.Size = new System.Drawing.Size(235, 26);
            this.txtTongTienThanhToan.TabIndex = 275;
            // 
            // dtpNgayNhanPhong
            // 
            this.dtpNgayNhanPhong.Checked = true;
            this.dtpNgayNhanPhong.FillColor = System.Drawing.Color.DarkOrange;
            this.dtpNgayNhanPhong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgayNhanPhong.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpNgayNhanPhong.Location = new System.Drawing.Point(12, 227);
            this.dtpNgayNhanPhong.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgayNhanPhong.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgayNhanPhong.Name = "dtpNgayNhanPhong";
            this.dtpNgayNhanPhong.Size = new System.Drawing.Size(234, 36);
            this.dtpNgayNhanPhong.TabIndex = 276;
            this.dtpNgayNhanPhong.Value = new System.DateTime(2024, 4, 23, 19, 49, 49, 316);
            // 
            // dtpNgayTraPhong
            // 
            this.dtpNgayTraPhong.Checked = true;
            this.dtpNgayTraPhong.FillColor = System.Drawing.Color.DarkOrange;
            this.dtpNgayTraPhong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgayTraPhong.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpNgayTraPhong.Location = new System.Drawing.Point(306, 227);
            this.dtpNgayTraPhong.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgayTraPhong.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgayTraPhong.Name = "dtpNgayTraPhong";
            this.dtpNgayTraPhong.Size = new System.Drawing.Size(236, 36);
            this.dtpNgayTraPhong.TabIndex = 277;
            this.dtpNgayTraPhong.Value = new System.DateTime(2024, 4, 23, 19, 49, 52, 669);
            // 
            // ChiTietKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 385);
            this.Controls.Add(this.dtpNgayTraPhong);
            this.Controls.Add(this.dtpNgayNhanPhong);
            this.Controls.Add(this.txtTongTienThanhToan);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtSoDienThoai);
            this.Controls.Add(this.txtCCCD);
            this.Controls.Add(this.txtTenKhachHang);
            this.Controls.Add(this.lblNgayTraPhong);
            this.Controls.Add(this.lblNgayNhanPhong);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblCCCD);
            this.Controls.Add(this.lblSoDienThoai);
            this.Controls.Add(this.lblHoVaTen);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.lblThongTinLienLac);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ChiTietKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChiTietKhachHang";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblThongTinLienLac;
        private Guna.UI2.WinForms.Guna2GradientButton btnThanhToan;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTongTien;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblHoVaTen;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSoDienThoai;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCCCD;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMail;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNgayNhanPhong;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNgayTraPhong;
        private Guna.UI2.WinForms.Guna2TextBox txtTenKhachHang;
        private Guna.UI2.WinForms.Guna2TextBox txtCCCD;
        private Guna.UI2.WinForms.Guna2TextBox txtSoDienThoai;
        private Guna.UI2.WinForms.Guna2TextBox txtMail;
        private Guna.UI2.WinForms.Guna2TextBox txtTongTienThanhToan;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgayNhanPhong;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgayTraPhong;
    }
}