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
        int iDKhachSan;
        private void btnChiTiet_Click(object sender, EventArgs e)
        {           
            ChiTietKhachSanAdmin f = new ChiTietKhachSanAdmin(iDKhachSan);
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
        }
    }
}
