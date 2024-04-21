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
    public partial class UCThongTinKhachSanUser : UserControl
    {
        string loaiKSan, mota;
        int iD;

        public UCThongTinKhachSanUser()
        {
            InitializeComponent();
        }
        public UCThongTinKhachSanUser(ThongTinKhachSan kqua)
        {
            InitializeComponent();
            txtTenKhachSan.Text = kqua.TenKhachSan;
            txtDiaDiemKhachSan.Text = kqua.DiaDiemKhachSan;
            loaiKSan = kqua.Loai;
            mota = kqua.MoTa;
            iD = kqua.IDKhachSan;
        }
        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            ChiTietKhachSanUser f = new ChiTietKhachSanUser(iD);
            f.ShowDialog();
        }
    }
}
