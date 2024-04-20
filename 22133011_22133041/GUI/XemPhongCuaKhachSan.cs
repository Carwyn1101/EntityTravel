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
    public partial class XemPhongCuaKhachSan : Form
    {
        int iDKhachSan;
        public XemPhongCuaKhachSan()
        {
            InitializeComponent();
        }
        public XemPhongCuaKhachSan(int iDKhachSan)
        {
            InitializeComponent();
            this.iDKhachSan = iDKhachSan;
        }

        private void XemPhongCuaKhachSan_Load(object sender, EventArgs e)
        {
            flpTrangChuKhachSan.Controls.Clear();
            UCThongTinPhongKhachSanUser f = new UCThongTinPhongKhachSanUser();
            f.LoadData(flpTrangChuKhachSan, iDKhachSan);
        }
    }
}
