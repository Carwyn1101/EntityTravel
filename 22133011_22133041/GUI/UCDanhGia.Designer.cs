﻿namespace GUI
{
    partial class UCDanhGia
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
            this.lblTenKhachHang = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblDiemDanhGia = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTraiNghiem = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.richTextBoxDanhGia = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTenKhachHang
            // 
            this.lblTenKhachHang.AutoSize = false;
            this.lblTenKhachHang.BackColor = System.Drawing.Color.Transparent;
            this.lblTenKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenKhachHang.Location = new System.Drawing.Point(4, 25);
            this.lblTenKhachHang.Margin = new System.Windows.Forms.Padding(4);
            this.lblTenKhachHang.Name = "lblTenKhachHang";
            this.lblTenKhachHang.Size = new System.Drawing.Size(197, 34);
            this.lblTenKhachHang.TabIndex = 0;
            this.lblTenKhachHang.Text = "Tên khách hàng";
            this.lblTenKhachHang.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblDiemDanhGia);
            this.panel2.Controls.Add(this.lblTraiNghiem);
            this.panel2.Controls.Add(this.richTextBoxDanhGia);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(212, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(587, 187);
            this.panel2.TabIndex = 5;
            // 
            // lblDiemDanhGia
            // 
            this.lblDiemDanhGia.AutoSize = false;
            this.lblDiemDanhGia.BackColor = System.Drawing.Color.Transparent;
            this.lblDiemDanhGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiemDanhGia.Location = new System.Drawing.Point(377, 4);
            this.lblDiemDanhGia.Margin = new System.Windows.Forms.Padding(4);
            this.lblDiemDanhGia.Name = "lblDiemDanhGia";
            this.lblDiemDanhGia.Size = new System.Drawing.Size(197, 46);
            this.lblDiemDanhGia.TabIndex = 30;
            this.lblDiemDanhGia.Text = "9.0";
            this.lblDiemDanhGia.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTraiNghiem
            // 
            this.lblTraiNghiem.AutoSize = false;
            this.lblTraiNghiem.BackColor = System.Drawing.Color.Transparent;
            this.lblTraiNghiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTraiNghiem.Location = new System.Drawing.Point(7, 16);
            this.lblTraiNghiem.Margin = new System.Windows.Forms.Padding(4);
            this.lblTraiNghiem.Name = "lblTraiNghiem";
            this.lblTraiNghiem.Size = new System.Drawing.Size(197, 34);
            this.lblTraiNghiem.TabIndex = 1;
            this.lblTraiNghiem.Text = "Tuyệt hảo";
            this.lblTraiNghiem.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // richTextBoxDanhGia
            // 
            this.richTextBoxDanhGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxDanhGia.Location = new System.Drawing.Point(5, 57);
            this.richTextBoxDanhGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBoxDanhGia.Name = "richTextBoxDanhGia";
            this.richTextBoxDanhGia.Size = new System.Drawing.Size(569, 126);
            this.richTextBoxDanhGia.TabIndex = 27;
            this.richTextBoxDanhGia.Text = "Homestay rất đẹp";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblTenKhachHang);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 187);
            this.panel1.TabIndex = 4;
            // 
            // UCDanhGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UCDanhGia";
            this.Size = new System.Drawing.Size(803, 193);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI2.WinForms.Guna2HtmlLabel lblTenKhachHang;
        public System.Windows.Forms.Panel panel2;
        public Guna.UI2.WinForms.Guna2HtmlLabel lblDiemDanhGia;
        public Guna.UI2.WinForms.Guna2HtmlLabel lblTraiNghiem;
        public System.Windows.Forms.RichTextBox richTextBoxDanhGia;
        public System.Windows.Forms.Panel panel1;
    }
}
