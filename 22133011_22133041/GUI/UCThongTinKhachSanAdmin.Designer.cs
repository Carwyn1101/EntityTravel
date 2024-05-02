namespace GUI
{
    partial class UCThongTinKhachSanAdmin
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
            this.pic_Anh1 = new System.Windows.Forms.PictureBox();
            this.lblTenKhachSan = new System.Windows.Forms.Label();
            this.lblDiaDiemKhachSan = new System.Windows.Forms.Label();
            this.pnlKhachSan = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Anh1)).BeginInit();
            this.pnlKhachSan.SuspendLayout();
            this.SuspendLayout();
            // 
            // pic_Anh1
            // 
            this.pic_Anh1.BackColor = System.Drawing.Color.White;
            this.pic_Anh1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_Anh1.Image = global::GUI.Properties.Resources.AnhUCKhachSan;
            this.pic_Anh1.Location = new System.Drawing.Point(-4, -4);
            this.pic_Anh1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pic_Anh1.Name = "pic_Anh1";
            this.pic_Anh1.Size = new System.Drawing.Size(212, 203);
            this.pic_Anh1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Anh1.TabIndex = 0;
            this.pic_Anh1.TabStop = false;
            // 
            // lblTenKhachSan
            // 
            this.lblTenKhachSan.AutoSize = true;
            this.lblTenKhachSan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenKhachSan.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblTenKhachSan.Location = new System.Drawing.Point(213, 2);
            this.lblTenKhachSan.Name = "lblTenKhachSan";
            this.lblTenKhachSan.Size = new System.Drawing.Size(209, 32);
            this.lblTenKhachSan.TabIndex = 2;
            this.lblTenKhachSan.Text = "Tên Khách Sạn";
            // 
            // lblDiaDiemKhachSan
            // 
            this.lblDiaDiemKhachSan.AutoSize = true;
            this.lblDiaDiemKhachSan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaDiemKhachSan.Location = new System.Drawing.Point(213, 58);
            this.lblDiaDiemKhachSan.Name = "lblDiaDiemKhachSan";
            this.lblDiaDiemKhachSan.Size = new System.Drawing.Size(89, 25);
            this.lblDiaDiemKhachSan.TabIndex = 3;
            this.lblDiaDiemKhachSan.Text = "Đà Nẵng";
            // 
            // pnlKhachSan
            // 
            this.pnlKhachSan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlKhachSan.Controls.Add(this.pic_Anh1);
            this.pnlKhachSan.Controls.Add(this.lblTenKhachSan);
            this.pnlKhachSan.Controls.Add(this.lblDiaDiemKhachSan);
            this.pnlKhachSan.Location = new System.Drawing.Point(3, 2);
            this.pnlKhachSan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlKhachSan.Name = "pnlKhachSan";
            this.pnlKhachSan.Size = new System.Drawing.Size(473, 200);
            this.pnlKhachSan.TabIndex = 8;
            this.pnlKhachSan.Click += new System.EventHandler(this.pnlKhachSan_Click);
            // 
            // UCThongTinKhachSanAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlKhachSan);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCThongTinKhachSanAdmin";
            this.Size = new System.Drawing.Size(477, 206);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Anh1)).EndInit();
            this.pnlKhachSan.ResumeLayout(false);
            this.pnlKhachSan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_Anh1;
        private System.Windows.Forms.Label lblTenKhachSan;
        private System.Windows.Forms.Label lblDiaDiemKhachSan;
        private System.Windows.Forms.Panel pnlKhachSan;
    }
}
