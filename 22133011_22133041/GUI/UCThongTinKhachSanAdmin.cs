using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class UCThongTinKhachSanAdmin : UserControl
    {
        string moTa, loai, hinhAnh1, hinhAnh2, hinhAnh3, hinhAnh4;
        int iDChuKhachSan; int iDKhachSan;

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            ThongTinKhachSan kSan = new ThongTinKhachSan();
            kSan.IDKhachSan = iDKhachSan;
            kSan.TenKhachSan = txtTenKhachSan.Text;
            kSan.DiaDiemKhachSan = txtDiaDiemKhachSan.Text;
            kSan.Loai = loai;
            kSan.MoTa = moTa;
            kSan.HinhAnh1 = hinhAnh1;
            kSan.HinhAnh2 = hinhAnh2;
            kSan.HinhAnh3 = hinhAnh3;
            kSan.HinhAnh4 = hinhAnh4;
            kSan.IDChuKhachSan = iDChuKhachSan;
            ChiTietKhachSanAdmin f = new ChiTietKhachSanAdmin(kSan);
            f.ShowDialog();
        }
        public UCThongTinKhachSanAdmin()
        {
            InitializeComponent();
        }
        public UCThongTinKhachSanAdmin(ThongTinKhachSan kSan)
        {
            InitializeComponent();
            iDKhachSan = kSan.IDKhachSan;
            txtTenKhachSan.Text = kSan.TenKhachSan;
            txtDiaDiemKhachSan.Text = kSan.DiaDiemKhachSan;
            loai = kSan.Loai;
            moTa = kSan.MoTa;
            hinhAnh1 = kSan.HinhAnh1;
            hinhAnh2 = kSan.HinhAnh2;
            hinhAnh3 = kSan.HinhAnh3;
            hinhAnh4 = kSan.HinhAnh4;
            iDChuKhachSan = (int)kSan.IDChuKhachSan;
        }
    }
}
