﻿namespace GUI
{
    partial class UCThongTinPhongKhachSanAdmin
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
            this.lblKichThuocPhong = new System.Windows.Forms.Label();
            this.linklblChiTietPhong = new System.Windows.Forms.LinkLabel();
            this.lblKichThuoc = new System.Windows.Forms.Label();
            this.lblGiaTien = new System.Windows.Forms.Label();
            this.lblSoGiaTien = new System.Windows.Forms.Label();
            this.pnl2 = new System.Windows.Forms.Panel();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.pnl2.SuspendLayout();
            this.pnl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblKichThuocPhong
            // 
            this.lblKichThuocPhong.AutoSize = true;
            this.lblKichThuocPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKichThuocPhong.Location = new System.Drawing.Point(185, 54);
            this.lblKichThuocPhong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKichThuocPhong.Name = "lblKichThuocPhong";
            this.lblKichThuocPhong.Size = new System.Drawing.Size(27, 20);
            this.lblKichThuocPhong.TabIndex = 6;
            this.lblKichThuocPhong.Text = "10";
            // 
            // linklblChiTietPhong
            // 
            this.linklblChiTietPhong.AutoSize = true;
            this.linklblChiTietPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklblChiTietPhong.LinkColor = System.Drawing.Color.DarkOrange;
            this.linklblChiTietPhong.Location = new System.Drawing.Point(8, 12);
            this.linklblChiTietPhong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linklblChiTietPhong.Name = "linklblChiTietPhong";
            this.linklblChiTietPhong.Size = new System.Drawing.Size(161, 24);
            this.linklblChiTietPhong.TabIndex = 5;
            this.linklblChiTietPhong.TabStop = true;
            this.linklblChiTietPhong.Text = "Phòng \"ABCDEF\"";
            this.linklblChiTietPhong.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblChiTietPhong_LinkClicked);
            // 
            // lblKichThuoc
            // 
            this.lblKichThuoc.AutoSize = true;
            this.lblKichThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKichThuoc.Location = new System.Drawing.Point(8, 54);
            this.lblKichThuoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKichThuoc.Name = "lblKichThuoc";
            this.lblKichThuoc.Size = new System.Drawing.Size(173, 20);
            this.lblKichThuoc.TabIndex = 1;
            this.lblKichThuoc.Text = "Kích Thước Phòng(m2):";
            // 
            // lblGiaTien
            // 
            this.lblGiaTien.AutoSize = true;
            this.lblGiaTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaTien.Location = new System.Drawing.Point(184, 84);
            this.lblGiaTien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGiaTien.Name = "lblGiaTien";
            this.lblGiaTien.Size = new System.Drawing.Size(72, 20);
            this.lblGiaTien.TabIndex = 0;
            this.lblGiaTien.Text = "Giá Tiền:";
            // 
            // lblSoGiaTien
            // 
            this.lblSoGiaTien.AutoSize = true;
            this.lblSoGiaTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoGiaTien.Location = new System.Drawing.Point(269, 84);
            this.lblSoGiaTien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSoGiaTien.Name = "lblSoGiaTien";
            this.lblSoGiaTien.Size = new System.Drawing.Size(84, 20);
            this.lblSoGiaTien.TabIndex = 1;
            this.lblSoGiaTien.Text = "1.000.000 ";
            // 
            // pnl2
            // 
            this.pnl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl2.Controls.Add(this.lblGiaTien);
            this.pnl2.Controls.Add(this.lblSoGiaTien);
            this.pnl2.Location = new System.Drawing.Point(262, 2);
            this.pnl2.Margin = new System.Windows.Forms.Padding(2);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(385, 116);
            this.pnl2.TabIndex = 13;
            // 
            // pnl1
            // 
            this.pnl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl1.Controls.Add(this.lblKichThuocPhong);
            this.pnl1.Controls.Add(this.linklblChiTietPhong);
            this.pnl1.Controls.Add(this.lblKichThuoc);
            this.pnl1.Location = new System.Drawing.Point(2, 2);
            this.pnl1.Margin = new System.Windows.Forms.Padding(2);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(266, 116);
            this.pnl1.TabIndex = 12;
            // 
            // UCThongTinPhongKhachSanAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl1);
            this.Controls.Add(this.pnl2);
            this.Name = "UCThongTinPhongKhachSanAdmin";
            this.Size = new System.Drawing.Size(648, 120);
            this.pnl2.ResumeLayout(false);
            this.pnl2.PerformLayout();
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lblKichThuocPhong;
        public System.Windows.Forms.LinkLabel linklblChiTietPhong;
        public System.Windows.Forms.Label lblKichThuoc;
        public System.Windows.Forms.Label lblGiaTien;
        public System.Windows.Forms.Label lblSoGiaTien;
        public System.Windows.Forms.Panel pnl2;
        public System.Windows.Forms.Panel pnl1;
    }
}
