namespace GUI
{
    partial class ThemUuDai
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
            this.lblMaGiam = new System.Windows.Forms.Label();
            this.lblGiaTriMa = new System.Windows.Forms.Label();
            this.txtMaGiamGia = new System.Windows.Forms.TextBox();
            this.cboGiaTriMa = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMaGiam
            // 
            this.lblMaGiam.AutoSize = true;
            this.lblMaGiam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaGiam.Location = new System.Drawing.Point(12, 24);
            this.lblMaGiam.Name = "lblMaGiam";
            this.lblMaGiam.Size = new System.Drawing.Size(126, 25);
            this.lblMaGiam.TabIndex = 0;
            this.lblMaGiam.Text = "Mã Giảm Giá";
            // 
            // lblGiaTriMa
            // 
            this.lblGiaTriMa.AutoSize = true;
            this.lblGiaTriMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaTriMa.Location = new System.Drawing.Point(12, 75);
            this.lblGiaTriMa.Name = "lblGiaTriMa";
            this.lblGiaTriMa.Size = new System.Drawing.Size(158, 25);
            this.lblGiaTriMa.TabIndex = 2;
            this.lblGiaTriMa.Text = "Giá Trị Giảm (%)";
            // 
            // txtMaGiamGia
            // 
            this.txtMaGiamGia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaGiamGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaGiamGia.Location = new System.Drawing.Point(183, 22);
            this.txtMaGiamGia.Name = "txtMaGiamGia";
            this.txtMaGiamGia.Size = new System.Drawing.Size(153, 30);
            this.txtMaGiamGia.TabIndex = 3;
            // 
            // cboGiaTriMa
            // 
            this.cboGiaTriMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGiaTriMa.FormattingEnabled = true;
            this.cboGiaTriMa.Items.AddRange(new object[] {
            "10",
            "15",
            "30",
            "50",
            "60"});
            this.cboGiaTriMa.Location = new System.Drawing.Point(183, 75);
            this.cboGiaTriMa.Name = "cboGiaTriMa";
            this.cboGiaTriMa.Size = new System.Drawing.Size(153, 33);
            this.cboGiaTriMa.TabIndex = 4;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(127, 128);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(121, 38);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm Mã";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // ThemUuDai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 176);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.cboGiaTriMa);
            this.Controls.Add(this.txtMaGiamGia);
            this.Controls.Add(this.lblGiaTriMa);
            this.Controls.Add(this.lblMaGiam);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ThemUuDai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThemUuDai";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaGiam;
        private System.Windows.Forms.Label lblGiaTriMa;
        private System.Windows.Forms.TextBox txtMaGiamGia;
        private System.Windows.Forms.ComboBox cboGiaTriMa;
        private System.Windows.Forms.Button btnThem;
    }
}