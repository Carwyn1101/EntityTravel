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
            this.lblDanhSachPhong.BackColor = System.Drawing.Color.Transparent;
            this.lblDanhSachPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhSachPhong.Location = new System.Drawing.Point(16, 15);
            this.lblDanhSachPhong.Margin = new System.Windows.Forms.Padding(4);
            this.lblDanhSachPhong.Name = "lblDanhSachPhong";
            this.lblDanhSachPhong.Size = new System.Drawing.Size(559, 54);
            this.lblDanhSachPhong.TabIndex = 0;
            this.lblDanhSachPhong.Text = "Danh sách phòng bạn đã đặt";
            // 
            // flpLichSuBook
            // 
            this.flpLichSuBook.AutoScroll = true;
            this.flpLichSuBook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpLichSuBook.Location = new System.Drawing.Point(16, 73);
            this.flpLichSuBook.Margin = new System.Windows.Forms.Padding(4);
            this.flpLichSuBook.Name = "flpLichSuBook";
            this.flpLichSuBook.Size = new System.Drawing.Size(911, 756);
            this.flpLichSuBook.TabIndex = 1;
            // 
            // LichSuBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 844);
            this.Controls.Add(this.flpLichSuBook);
            this.Controls.Add(this.lblDanhSachPhong);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LichSuBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LichSuBook";
            this.Load += new System.EventHandler(this.LichSuBook_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lblDanhSachPhong;
        private System.Windows.Forms.FlowLayoutPanel flpLichSuBook;
    }
}