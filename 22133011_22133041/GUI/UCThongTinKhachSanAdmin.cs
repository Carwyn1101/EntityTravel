using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class UCThongTinKhachSanAdmin : UserControl
    {
        int iDKhachSan; 
        string appDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
        public UCThongTinKhachSanAdmin()
        {
            InitializeComponent();
        }
        public UCThongTinKhachSanAdmin(ThongTinKhachSan kSan)
        {
            InitializeComponent();
            iDKhachSan = kSan.IDKhachSan;
            lblTenKhachSan.Text = kSan.TenKhachSan;
            lblDiaDiemKhachSan.Text = kSan.DiaDiemKhachSan;
            string image1 = Path.Combine(appDirectory, kSan.HinhAnh1);
            pic_Anh1.Image = Image.FromFile(image1);
        }
        private void pnlKhachSan_Click(object sender, EventArgs e)
        {
            Program.iDKhachSanInstance = iDKhachSan;
            ChiTietKhachSanAdmin f = new ChiTietKhachSanAdmin();
            f.ShowDialog();
        }
    }
}
