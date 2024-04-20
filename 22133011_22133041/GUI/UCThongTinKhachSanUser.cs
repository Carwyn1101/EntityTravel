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

        public void LoadData(FlowLayoutPanel flpTrangChuUser)
        {
            ThongTinKhachSanDAO khachSanDAO = new ThongTinKhachSanDAO();
            List<UCThongTinKhachSanUser> khachSanList = khachSanDAO.GetAllKhachSan();
            foreach (UCThongTinKhachSanUser uc in khachSanList)
            {
                flpTrangChuUser.Controls.Add(uc);
            }
        }
        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            ChiTietKhachSanUser f = new ChiTietKhachSanUser(iD);
            f.ShowDialog();
        }

        public void LoadDataTimKiem(FlowLayoutPanel flpTrangChu, string dd)
        {
            ThongTinKhachSanDAO khachSanDAO = new ThongTinKhachSanDAO();
            List<UCThongTinKhachSanUser> khachSanList = khachSanDAO.SearchKhachSanByDiaDiem(dd);
            foreach (UCThongTinKhachSanUser uc in khachSanList)
            {
                flpTrangChu.Controls.Add(uc);
            }
        }
    }
}
