﻿namespace GUI
{
    partial class ChiTietKhachHangAdmin
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
            this.flpChiTietKhachHang = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // lblThongTinLienLac
            // 
            this.lblThongTinLienLac.AutoSize = true;
            this.lblThongTinLienLac.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTinLienLac.Location = new System.Drawing.Point(15, 23);
            this.lblThongTinLienLac.Name = "lblThongTinLienLac";
            this.lblThongTinLienLac.Size = new System.Drawing.Size(338, 42);
            this.lblThongTinLienLac.TabIndex = 301;
            this.lblThongTinLienLac.Text = "Chi tiết khách hàng";
            this.lblThongTinLienLac.UseWaitCursor = true;
            // 
            // flpChiTietKhachHang
            // 
            this.flpChiTietKhachHang.AutoScroll = true;
            this.flpChiTietKhachHang.Location = new System.Drawing.Point(8, 68);
            this.flpChiTietKhachHang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flpChiTietKhachHang.Name = "flpChiTietKhachHang";
            this.flpChiTietKhachHang.Size = new System.Drawing.Size(1172, 660);
            this.flpChiTietKhachHang.TabIndex = 302;
            // 
            // ChiTietKhachHangAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 742);
            this.Controls.Add(this.flpChiTietKhachHang);
            this.Controls.Add(this.lblThongTinLienLac);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ChiTietKhachHangAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChiTietKhachHangAdmin";
            this.Load += new System.EventHandler(this.ChiTietKhachHangAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lblThongTinLienLac;
        private System.Windows.Forms.FlowLayoutPanel flpChiTietKhachHang;
    }
}