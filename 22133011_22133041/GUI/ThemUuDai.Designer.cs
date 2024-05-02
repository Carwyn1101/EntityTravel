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
            this.cboGiaTriMa = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtMaGiamGia = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtgvDanhSachMaGiam = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachMaGiam)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMaGiam
            // 
            this.lblMaGiam.AutoSize = true;
            this.lblMaGiam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaGiam.Location = new System.Drawing.Point(9, 20);
            this.lblMaGiam.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaGiam.Name = "lblMaGiam";
            this.lblMaGiam.Size = new System.Drawing.Size(102, 20);
            this.lblMaGiam.TabIndex = 0;
            this.lblMaGiam.Text = "Mã Giảm Giá";
            // 
            // lblGiaTriMa
            // 
            this.lblGiaTriMa.AutoSize = true;
            this.lblGiaTriMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaTriMa.Location = new System.Drawing.Point(9, 61);
            this.lblGiaTriMa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGiaTriMa.Name = "lblGiaTriMa";
            this.lblGiaTriMa.Size = new System.Drawing.Size(125, 20);
            this.lblGiaTriMa.TabIndex = 2;
            this.lblGiaTriMa.Text = "Giá Trị Giảm (%)";
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
            this.cboGiaTriMa.Location = new System.Drawing.Point(137, 61);
            this.cboGiaTriMa.Margin = new System.Windows.Forms.Padding(2);
            this.cboGiaTriMa.Name = "cboGiaTriMa";
            this.cboGiaTriMa.Size = new System.Drawing.Size(155, 28);
            this.cboGiaTriMa.TabIndex = 4;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(11, 111);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(91, 31);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm Mã";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(201, 111);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(91, 31);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Sửa Mã";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(106, 111);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(91, 31);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa Mã";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtMaGiamGia
            // 
            this.txtMaGiamGia.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtMaGiamGia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaGiamGia.DefaultText = "";
            this.txtMaGiamGia.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaGiamGia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaGiamGia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaGiamGia.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaGiamGia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaGiamGia.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txtMaGiamGia.ForeColor = System.Drawing.Color.Black;
            this.txtMaGiamGia.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaGiamGia.Location = new System.Drawing.Point(138, 20);
            this.txtMaGiamGia.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtMaGiamGia.Name = "txtMaGiamGia";
            this.txtMaGiamGia.PasswordChar = '\0';
            this.txtMaGiamGia.PlaceholderText = "";
            this.txtMaGiamGia.SelectedText = "";
            this.txtMaGiamGia.Size = new System.Drawing.Size(154, 27);
            this.txtMaGiamGia.TabIndex = 9;
            // 
            // dtgvDanhSachMaGiam
            // 
            this.dtgvDanhSachMaGiam.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgvDanhSachMaGiam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDanhSachMaGiam.Location = new System.Drawing.Point(308, 20);
            this.dtgvDanhSachMaGiam.Name = "dtgvDanhSachMaGiam";
            this.dtgvDanhSachMaGiam.RowHeadersVisible = false;
            this.dtgvDanhSachMaGiam.Size = new System.Drawing.Size(304, 239);
            this.dtgvDanhSachMaGiam.TabIndex = 10;
            // 
            // ThemUuDai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 271);
            this.Controls.Add(this.dtgvDanhSachMaGiam);
            this.Controls.Add(this.txtMaGiamGia);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.cboGiaTriMa);
            this.Controls.Add(this.lblGiaTriMa);
            this.Controls.Add(this.lblMaGiam);
            this.Name = "ThemUuDai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThemUuDai";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachMaGiam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaGiam;
        private System.Windows.Forms.Label lblGiaTriMa;
        public System.Windows.Forms.ComboBox cboGiaTriMa;
        public System.Windows.Forms.Button btnThem;
        public System.Windows.Forms.Button btnSua;
        public System.Windows.Forms.Button btnXoa;
        public Guna.UI2.WinForms.Guna2TextBox txtMaGiamGia;
        public System.Windows.Forms.DataGridView dtgvDanhSachMaGiam;
    }
}