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
            this.btnTimKiemPhong = new System.Windows.Forms.Button();
            this.cboLoaiPhong = new System.Windows.Forms.ComboBox();
            this.lblLoaiPhong = new System.Windows.Forms.Label();
            this.lblPhong = new System.Windows.Forms.Label();
            this.flpTrangChuKhachSan = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlTienDe.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTienDe
            // 
            this.pnlTienDe.Controls.Add(this.btnTimKiemPhong);
            this.pnlTienDe.Controls.Add(this.cboLoaiPhong);
            this.pnlTienDe.Controls.Add(this.lblLoaiPhong);
            this.pnlTienDe.Controls.Add(this.lblPhong);
            this.pnlTienDe.Location = new System.Drawing.Point(3, 1);
            this.pnlTienDe.Name = "pnlTienDe";
            this.pnlTienDe.Size = new System.Drawing.Size(794, 133);
            this.pnlTienDe.TabIndex = 6;
            // 
            // btnTimKiemPhong
            // 
            this.btnTimKiemPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemPhong.Location = new System.Drawing.Point(220, 80);
            this.btnTimKiemPhong.Name = "btnTimKiemPhong";
            this.btnTimKiemPhong.Size = new System.Drawing.Size(108, 34);
            this.btnTimKiemPhong.TabIndex = 12;
            this.btnTimKiemPhong.Text = "Tìm kiếm";
            this.btnTimKiemPhong.UseVisualStyleBackColor = true;
            this.btnTimKiemPhong.Click += new System.EventHandler(this.btnTimKiemPhong_Click);
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
            this.cboLoaiPhong.Location = new System.Drawing.Point(16, 84);
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
            this.lblPhong.Location = new System.Drawing.Point(10, 6);
            this.lblPhong.Name = "lblPhong";
            this.lblPhong.Size = new System.Drawing.Size(169, 32);
            this.lblPhong.TabIndex = 0;
            this.lblPhong.Text = "Phòng trống";
            // 
            // flpTrangChuKhachSan
            // 
            this.flpTrangChuKhachSan.Location = new System.Drawing.Point(3, 140);
            this.flpTrangChuKhachSan.Name = "flpTrangChuKhachSan";
            this.flpTrangChuKhachSan.Size = new System.Drawing.Size(794, 615);
            this.flpTrangChuKhachSan.TabIndex = 7;
            // 
            // XemPhongCuaKhachSan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 759);
            this.Controls.Add(this.pnlTienDe);
            this.Controls.Add(this.flpTrangChuKhachSan);
            this.Name = "XemPhongCuaKhachSan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XemPhongCuaKhachSan";
            this.pnlTienDe.ResumeLayout(false);
            this.pnlTienDe.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Panel pnlTienDe;
        private System.Windows.Forms.Button btnTimKiemPhong;
        private System.Windows.Forms.ComboBox cboLoaiPhong;
        private System.Windows.Forms.Label lblLoaiPhong;
        private System.Windows.Forms.Label lblPhong;
        private System.Windows.Forms.FlowLayoutPanel flpTrangChuKhachSan;
    }
}