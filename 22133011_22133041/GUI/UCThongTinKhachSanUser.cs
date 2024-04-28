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
    public partial class UCThongTinKhachSanUser : UserControl
    {
        string loaiKSan, mota;
        int iD;
        string appDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
        public UCThongTinKhachSanUser()
        {
            InitializeComponent();
        }
        public UCThongTinKhachSanUser(ThongTinKhachSan kQua)
        {
            InitializeComponent();
            lblTenKhachSan.Text = kQua.TenKhachSan;
            lblDiaDiemKhachSan.Text = kQua.DiaDiemKhachSan;
            loaiKSan = kQua.Loai;
            mota = kQua.MoTa;
            iD = kQua.IDKhachSan;
            string image1 = Path.Combine(appDirectory, kQua.HinhAnh1);
            pic_Anh.Image = Image.FromFile(image1);
        }
        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            Program.iDKhachSanInstance = iD;
            ChiTietKhachSanUser f = new ChiTietKhachSanUser();
            f.ShowDialog();
        }
    }
}
