﻿namespace GUI
{
    partial class TrangChuAdmin
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
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.flpTrangChu = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTenTaiKhoan = new System.Windows.Forms.Label();
            this.btnChoThue = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lblTenTrangChu = new System.Windows.Forms.Label();
            this.pnlTrangChu = new System.Windows.Forms.Panel();
            this.pic_DangXuat = new System.Windows.Forms.PictureBox();
            this.pic_AnhDaiDien = new System.Windows.Forms.PictureBox();
            this.pnlTrangChu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_DangXuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_AnhDaiDien)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Separator1.FillColor = System.Drawing.Color.DarkOrange;
            this.guna2Separator1.Location = new System.Drawing.Point(57, 148);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(1288, 22);
            this.guna2Separator1.TabIndex = 29;
            // 
            // flpTrangChu
            // 
            this.flpTrangChu.AutoScroll = true;
            this.flpTrangChu.Location = new System.Drawing.Point(3, 162);
            this.flpTrangChu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flpTrangChu.Name = "flpTrangChu";
            this.flpTrangChu.Size = new System.Drawing.Size(1468, 431);
            this.flpTrangChu.TabIndex = 28;
            // 
            // lblTenTaiKhoan
            // 
            this.lblTenTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenTaiKhoan.Location = new System.Drawing.Point(1230, 110);
            this.lblTenTaiKhoan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenTaiKhoan.Name = "lblTenTaiKhoan";
            this.lblTenTaiKhoan.Size = new System.Drawing.Size(189, 39);
            this.lblTenTaiKhoan.TabIndex = 24;
            this.lblTenTaiKhoan.Text = "Tên Tài Khoản";
            this.lblTenTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnChoThue
            // 
            this.btnChoThue.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnChoThue.Animated = true;
            this.btnChoThue.AutoRoundedCorners = true;
            this.btnChoThue.BackColor = System.Drawing.Color.Transparent;
            this.btnChoThue.BorderRadius = 19;
            this.btnChoThue.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChoThue.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChoThue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChoThue.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChoThue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChoThue.FillColor = System.Drawing.Color.Orange;
            this.btnChoThue.FillColor2 = System.Drawing.Color.PeachPuff;
            this.btnChoThue.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btnChoThue.ForeColor = System.Drawing.Color.Black;
            this.btnChoThue.Location = new System.Drawing.Point(1087, 97);
            this.btnChoThue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChoThue.Name = "btnChoThue";
            this.btnChoThue.Size = new System.Drawing.Size(136, 41);
            this.btnChoThue.TabIndex = 22;
            this.btnChoThue.Text = "Cho Thuê";
            this.btnChoThue.Click += new System.EventHandler(this.btnChoThue_Click);
            // 
            // lblTenTrangChu
            // 
            this.lblTenTrangChu.AutoSize = true;
            this.lblTenTrangChu.BackColor = System.Drawing.Color.Transparent;
            this.lblTenTrangChu.Font = new System.Drawing.Font("NSimSun", 40.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenTrangChu.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblTenTrangChu.Location = new System.Drawing.Point(282, 48);
            this.lblTenTrangChu.Name = "lblTenTrangChu";
            this.lblTenTrangChu.Size = new System.Drawing.Size(527, 54);
            this.lblTenTrangChu.TabIndex = 15;
            this.lblTenTrangChu.Text = "Enjoy your journey";
            this.lblTenTrangChu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTrangChu
            // 
            this.pnlTrangChu.Controls.Add(this.pic_DangXuat);
            this.pnlTrangChu.Controls.Add(this.lblTenTaiKhoan);
            this.pnlTrangChu.Controls.Add(this.pic_AnhDaiDien);
            this.pnlTrangChu.Controls.Add(this.btnChoThue);
            this.pnlTrangChu.Controls.Add(this.lblTenTrangChu);
            this.pnlTrangChu.Location = new System.Drawing.Point(3, -4);
            this.pnlTrangChu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlTrangChu.Name = "pnlTrangChu";
            this.pnlTrangChu.Size = new System.Drawing.Size(1468, 162);
            this.pnlTrangChu.TabIndex = 27;
            // 
            // pic_DangXuat
            // 
            this.pic_DangXuat.BackColor = System.Drawing.Color.Transparent;
            this.pic_DangXuat.Image = global::GUI.Properties.Resources.icons8_logout;
            this.pic_DangXuat.Location = new System.Drawing.Point(1408, 66);
            this.pic_DangXuat.Name = "pic_DangXuat";
            this.pic_DangXuat.Size = new System.Drawing.Size(38, 41);
            this.pic_DangXuat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_DangXuat.TabIndex = 25;
            this.pic_DangXuat.TabStop = false;
            // 
            // pic_AnhDaiDien
            // 
            this.pic_AnhDaiDien.BackColor = System.Drawing.Color.Transparent;
            this.pic_AnhDaiDien.Image = global::GUI.Properties.Resources._8;
            this.pic_AnhDaiDien.Location = new System.Drawing.Point(1275, 21);
            this.pic_AnhDaiDien.Margin = new System.Windows.Forms.Padding(4);
            this.pic_AnhDaiDien.Name = "pic_AnhDaiDien";
            this.pic_AnhDaiDien.Size = new System.Drawing.Size(91, 81);
            this.pic_AnhDaiDien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_AnhDaiDien.TabIndex = 23;
            this.pic_AnhDaiDien.TabStop = false;
            // 
            // TrangChuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1475, 588);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.flpTrangChu);
            this.Controls.Add(this.pnlTrangChu);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TrangChuAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrangChuAdmin";
            this.pnlTrangChu.ResumeLayout(false);
            this.pnlTrangChu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_DangXuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_AnhDaiDien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        public System.Windows.Forms.FlowLayoutPanel flpTrangChu;
        private System.Windows.Forms.PictureBox pic_DangXuat;
        private System.Windows.Forms.Label lblTenTaiKhoan;
        private System.Windows.Forms.PictureBox pic_AnhDaiDien;
        private Guna.UI2.WinForms.Guna2GradientButton btnChoThue;
        private System.Windows.Forms.Label lblTenTrangChu;
        private System.Windows.Forms.Panel pnlTrangChu;
    }
}
