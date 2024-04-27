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
            this.pnl = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Anh1)).BeginInit();
            this.pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // pic_Anh1
            // 
            this.pic_Anh1.BackColor = System.Drawing.Color.White;
            this.pic_Anh1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_Anh1.Image = global::GUI.Properties.Resources.AnhUCKhachSan;
            this.pic_Anh1.Location = new System.Drawing.Point(-3, -3);
            this.pic_Anh1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pic_Anh1.Name = "pic_Anh1";
            this.pic_Anh1.Size = new System.Drawing.Size(159, 165);
            this.pic_Anh1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Anh1.TabIndex = 0;
            this.pic_Anh1.TabStop = false;
            // 
            // lblTenKhachSan
            // 
            this.lblTenKhachSan.AutoSize = true;
            this.lblTenKhachSan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenKhachSan.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblTenKhachSan.Location = new System.Drawing.Point(160, 2);
            this.lblTenKhachSan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenKhachSan.Name = "lblTenKhachSan";
            this.lblTenKhachSan.Size = new System.Drawing.Size(161, 26);
            this.lblTenKhachSan.TabIndex = 2;
            this.lblTenKhachSan.Text = "Tên Khách Sạn";
            // 
            // lblDiaDiemKhachSan
            // 
            this.lblDiaDiemKhachSan.AutoSize = true;
            this.lblDiaDiemKhachSan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaDiemKhachSan.Location = new System.Drawing.Point(160, 47);
            this.lblDiaDiemKhachSan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDiaDiemKhachSan.Name = "lblDiaDiemKhachSan";
            this.lblDiaDiemKhachSan.Size = new System.Drawing.Size(72, 20);
            this.lblDiaDiemKhachSan.TabIndex = 3;
            this.lblDiaDiemKhachSan.Text = "Đà Nẵng";
            // 
            // pnl
            // 
            this.pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl.Controls.Add(this.pic_Anh1);
            this.pnl.Controls.Add(this.lblTenKhachSan);
            this.pnl.Controls.Add(this.lblDiaDiemKhachSan);
            this.pnl.Location = new System.Drawing.Point(2, 2);
            this.pnl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(355, 163);
            this.pnl.TabIndex = 8;
            this.pnl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnl_MouseClick);
            // 
            // UCThongTinKhachSanAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl);
            this.Name = "UCThongTinKhachSanAdmin";
            this.Size = new System.Drawing.Size(358, 167);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Anh1)).EndInit();
            this.pnl.ResumeLayout(false);
            this.pnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_Anh1;
        private System.Windows.Forms.Label lblTenKhachSan;
        private System.Windows.Forms.Label lblDiaDiemKhachSan;
        private System.Windows.Forms.Panel pnl;
    }
}
