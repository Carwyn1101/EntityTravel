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
    public partial class DanhGiaCuaKhachHang : Form
    {      
        int iD;
        public DanhGiaCuaKhachHang()
        {
            InitializeComponent();
        }
        public DanhGiaCuaKhachHang(int id)
        {
            this.iD = id;
        }
        private void DanhGiaCuaKhachHang_Load(object sender, EventArgs e)
        {
            UCDanhGia f = new UCDanhGia();
            f.LoadDataDanhGia(flpDanhGia, iD);
        }
    }
}
