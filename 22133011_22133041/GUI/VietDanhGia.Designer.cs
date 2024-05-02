namespace GUI
{
    partial class VietDanhGia
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
            this.pnl2 = new System.Windows.Forms.Panel();
            this.cboDiemDanhGia = new System.Windows.Forms.ComboBox();
            this.cboTraiNghiem = new System.Windows.Forms.ComboBox();
            this.richTextBoxDanhGia = new System.Windows.Forms.RichTextBox();
            this.btnDangBai = new System.Windows.Forms.Button();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.cboTenKhachHang = new System.Windows.Forms.ComboBox();
            this.pnl2.SuspendLayout();
            this.pnl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl2
            // 
            this.pnl2.Controls.Add(this.cboDiemDanhGia);
            this.pnl2.Controls.Add(this.cboTraiNghiem);
            this.pnl2.Controls.Add(this.richTextBoxDanhGia);
            this.pnl2.Controls.Add(this.btnDangBai);
            this.pnl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl2.Location = new System.Drawing.Point(212, 2);
            this.pnl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(581, 188);
            this.pnl2.TabIndex = 7;
            // 
            // cboDiemDanhGia
            // 
            this.cboDiemDanhGia.FormattingEnabled = true;
            this.cboDiemDanhGia.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cboDiemDanhGia.Location = new System.Drawing.Point(397, 15);
            this.cboDiemDanhGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboDiemDanhGia.Name = "cboDiemDanhGia";
            this.cboDiemDanhGia.Size = new System.Drawing.Size(160, 28);
            this.cboDiemDanhGia.TabIndex = 29;
            this.cboDiemDanhGia.Text = "Điểm đánh giá";
            // 
            // cboTraiNghiem
            // 
            this.cboTraiNghiem.FormattingEnabled = true;
            this.cboTraiNghiem.Items.AddRange(new object[] {
            "Rất tệ",
            "Kém",
            "Tạm",
            "Tốt",
            "Tuyệt hảo"});
            this.cboTraiNghiem.Location = new System.Drawing.Point(5, 15);
            this.cboTraiNghiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboTraiNghiem.Name = "cboTraiNghiem";
            this.cboTraiNghiem.Size = new System.Drawing.Size(131, 28);
            this.cboTraiNghiem.TabIndex = 28;
            this.cboTraiNghiem.Text = "Trải nghiệm";
            // 
            // richTextBoxDanhGia
            // 
            this.richTextBoxDanhGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxDanhGia.Location = new System.Drawing.Point(5, 57);
            this.richTextBoxDanhGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBoxDanhGia.Name = "richTextBoxDanhGia";
            this.richTextBoxDanhGia.Size = new System.Drawing.Size(569, 86);
            this.richTextBoxDanhGia.TabIndex = 27;
            this.richTextBoxDanhGia.Text = "Homestay rất đẹp";
            // 
            // btnDangBai
            // 
            this.btnDangBai.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDangBai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangBai.Location = new System.Drawing.Point(237, 149);
            this.btnDangBai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDangBai.Name = "btnDangBai";
            this.btnDangBai.Size = new System.Drawing.Size(128, 34);
            this.btnDangBai.TabIndex = 0;
            this.btnDangBai.Text = "Đăng bài";
            this.btnDangBai.UseVisualStyleBackColor = true;
            this.btnDangBai.Click += new System.EventHandler(this.btnDangBai_Click);
            // 
            // pnl1
            // 
            this.pnl1.Controls.Add(this.cboTenKhachHang);
            this.pnl1.Location = new System.Drawing.Point(2, 2);
            this.pnl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(211, 188);
            this.pnl1.TabIndex = 6;
            // 
            // cboTenKhachHang
            // 
            this.cboTenKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTenKhachHang.FormattingEnabled = true;
            this.cboTenKhachHang.Items.AddRange(new object[] {
            "Khách hàng ẩn danh",
            "Nhập tên"});
            this.cboTenKhachHang.Location = new System.Drawing.Point(4, 15);
            this.cboTenKhachHang.Margin = new System.Windows.Forms.Padding(4);
            this.cboTenKhachHang.Name = "cboTenKhachHang";
            this.cboTenKhachHang.Size = new System.Drawing.Size(199, 33);
            this.cboTenKhachHang.TabIndex = 1;
            // 
            // VietDanhGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 192);
            this.Controls.Add(this.pnl2);
            this.Controls.Add(this.pnl1);
            this.Name = "VietDanhGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VietDanhGia";
            this.pnl2.ResumeLayout(false);
            this.pnl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl2;
        private System.Windows.Forms.ComboBox cboDiemDanhGia;
        private System.Windows.Forms.ComboBox cboTraiNghiem;
        private System.Windows.Forms.RichTextBox richTextBoxDanhGia;
        private System.Windows.Forms.Button btnDangBai;
        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.ComboBox cboTenKhachHang;
    }
}