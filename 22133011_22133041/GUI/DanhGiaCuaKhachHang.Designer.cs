namespace GUI
{
    partial class DanhGiaCuaKhachHang
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
            this.flpDanhGia = new System.Windows.Forms.FlowLayoutPanel();
            this.btnVietDanhGia = new System.Windows.Forms.Button();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblBaiDanhGia = new System.Windows.Forms.Label();
            this.pnlTieuDe = new System.Windows.Forms.Panel();
            this.pnlTieuDe.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpDanhGia
            // 
            this.flpDanhGia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpDanhGia.Location = new System.Drawing.Point(2, 72);
            this.flpDanhGia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flpDanhGia.Name = "flpDanhGia";
            this.flpDanhGia.Size = new System.Drawing.Size(609, 455);
            this.flpDanhGia.TabIndex = 9;
            // 
            // btnVietDanhGia
            // 
            this.btnVietDanhGia.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVietDanhGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVietDanhGia.Location = new System.Drawing.Point(498, 6);
            this.btnVietDanhGia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVietDanhGia.Name = "btnVietDanhGia";
            this.btnVietDanhGia.Size = new System.Drawing.Size(100, 32);
            this.btnVietDanhGia.TabIndex = 1;
            this.btnVietDanhGia.Text = "Viết đánh giá";
            this.btnVietDanhGia.UseVisualStyleBackColor = true;
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.Location = new System.Drawing.Point(31, 6);
            this.lblTieuDe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(394, 20);
            this.lblTieuDe.TabIndex = 6;
            this.lblTieuDe.Text = "Chúng tôi cố gắng mang đến 100% đánh giá chân thật";
            // 
            // lblBaiDanhGia
            // 
            this.lblBaiDanhGia.AutoSize = true;
            this.lblBaiDanhGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaiDanhGia.Location = new System.Drawing.Point(9, 49);
            this.lblBaiDanhGia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBaiDanhGia.Name = "lblBaiDanhGia";
            this.lblBaiDanhGia.Size = new System.Drawing.Size(214, 20);
            this.lblBaiDanhGia.TabIndex = 8;
            this.lblBaiDanhGia.Text = "Bài đánh giá của khách hàng";
            // 
            // pnlTieuDe
            // 
            this.pnlTieuDe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTieuDe.Controls.Add(this.btnVietDanhGia);
            this.pnlTieuDe.Controls.Add(this.lblTieuDe);
            this.pnlTieuDe.Location = new System.Drawing.Point(2, 2);
            this.pnlTieuDe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlTieuDe.Name = "pnlTieuDe";
            this.pnlTieuDe.Size = new System.Drawing.Size(609, 44);
            this.pnlTieuDe.TabIndex = 10;
            // 
            // DanhGiaCuaKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 532);
            this.Controls.Add(this.flpDanhGia);
            this.Controls.Add(this.lblBaiDanhGia);
            this.Controls.Add(this.pnlTieuDe);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DanhGiaCuaKhachHang";
            this.Text = "DanhGiaCuaKhachHang";
            this.Load += new System.EventHandler(this.DanhGiaCuaKhachHang_Load);
            this.pnlTieuDe.ResumeLayout(false);
            this.pnlTieuDe.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpDanhGia;
        private System.Windows.Forms.Button btnVietDanhGia;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblBaiDanhGia;
        private System.Windows.Forms.Panel pnlTieuDe;
    }
}