namespace GUI
{
    partial class LichSuBook
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
            this.lblDanhSachPhong = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.flpLichSuBook = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // lblDanhSachPhong
            // 
            this.lblDanhSachPhong.AutoSize = false;
            this.lblDanhSachPhong.BackColor = System.Drawing.Color.Transparent;
            this.lblDanhSachPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhSachPhong.Location = new System.Drawing.Point(12, 12);
            this.lblDanhSachPhong.Name = "lblDanhSachPhong";
            this.lblDanhSachPhong.Size = new System.Drawing.Size(684, 41);
            this.lblDanhSachPhong.TabIndex = 0;
            this.lblDanhSachPhong.Text = "Danh sách phòng bạn đã đặt";
            // 
            // flpLichSuBook
            // 
            this.flpLichSuBook.AutoScroll = true;
            this.flpLichSuBook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpLichSuBook.Location = new System.Drawing.Point(12, 59);
            this.flpLichSuBook.Name = "flpLichSuBook";
            this.flpLichSuBook.Size = new System.Drawing.Size(684, 615);
            this.flpLichSuBook.TabIndex = 1;
            // 
            // LichSuBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 686);
            this.Controls.Add(this.flpLichSuBook);
            this.Controls.Add(this.lblDanhSachPhong);
            this.Name = "LichSuBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LichSuBook";
            this.Load += new System.EventHandler(this.LichSuBook_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lblDanhSachPhong;
        public System.Windows.Forms.FlowLayoutPanel flpLichSuBook;
    }
}