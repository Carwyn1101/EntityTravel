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
            this.btnVietDanhGia = new System.Windows.Forms.Button();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblBaiDanhGia = new System.Windows.Forms.Label();
            this.pnlTieuDe = new System.Windows.Forms.Panel();
            this.flpDanhGia = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlTieuDe.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVietDanhGia
            // 
            this.btnVietDanhGia.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVietDanhGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVietDanhGia.Location = new System.Drawing.Point(655, 7);
            this.btnVietDanhGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVietDanhGia.Name = "btnVietDanhGia";
            this.btnVietDanhGia.Size = new System.Drawing.Size(147, 39);
            this.btnVietDanhGia.TabIndex = 1;
            this.btnVietDanhGia.Text = "Viết đánh giá";
            this.btnVietDanhGia.UseVisualStyleBackColor = true;
            this.btnVietDanhGia.Click += new System.EventHandler(this.btnVietDanhGia_Click);
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.Location = new System.Drawing.Point(41, 7);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(484, 25);
            this.lblTieuDe.TabIndex = 6;
            this.lblTieuDe.Text = "Chúng tôi cố gắng mang đến 100% đánh giá chân thật";
            // 
            // lblBaiDanhGia
            // 
            this.lblBaiDanhGia.AutoSize = true;
            this.lblBaiDanhGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaiDanhGia.Location = new System.Drawing.Point(12, 60);
            this.lblBaiDanhGia.Name = "lblBaiDanhGia";
            this.lblBaiDanhGia.Size = new System.Drawing.Size(264, 25);
            this.lblBaiDanhGia.TabIndex = 8;
            this.lblBaiDanhGia.Text = "Bài đánh giá của khách hàng";
            // 
            // pnlTieuDe
            // 
            this.pnlTieuDe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTieuDe.Controls.Add(this.btnVietDanhGia);
            this.pnlTieuDe.Controls.Add(this.lblTieuDe);
            this.pnlTieuDe.Location = new System.Drawing.Point(3, 2);
            this.pnlTieuDe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlTieuDe.Name = "pnlTieuDe";
            this.pnlTieuDe.Size = new System.Drawing.Size(811, 54);
            this.pnlTieuDe.TabIndex = 10;
            // 
            // flpDanhGia
            // 
            this.flpDanhGia.AutoScroll = true;
            this.flpDanhGia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpDanhGia.Location = new System.Drawing.Point(3, 89);
            this.flpDanhGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flpDanhGia.Name = "flpDanhGia";
            this.flpDanhGia.Size = new System.Drawing.Size(811, 560);
            this.flpDanhGia.TabIndex = 9;
            // 
            // DanhGiaCuaKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 655);
            this.Controls.Add(this.flpDanhGia);
            this.Controls.Add(this.lblBaiDanhGia);
            this.Controls.Add(this.pnlTieuDe);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DanhGiaCuaKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DanhGiaCuaKhachHang";
            this.Load += new System.EventHandler(this.DanhGiaCuaKhachHang_Load);
            this.pnlTieuDe.ResumeLayout(false);
            this.pnlTieuDe.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnVietDanhGia;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblBaiDanhGia;
        private System.Windows.Forms.Panel pnlTieuDe;
        private System.Windows.Forms.FlowLayoutPanel flpDanhGia;
    }
}