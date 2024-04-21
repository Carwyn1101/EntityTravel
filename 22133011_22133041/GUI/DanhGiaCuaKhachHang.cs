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
        int iDKSan;
        DanhGiaDAO dGia = new DanhGiaDAO();
        public DanhGiaCuaKhachHang()
        {
            InitializeComponent();            
        }
        public DanhGiaCuaKhachHang(int id)
        {
            InitializeComponent();
            iDKSan = id;
        }
        private void DanhGiaCuaKhachHang_Load(object sender, EventArgs e)
        {
            dGia.LoadDataDanhGia(flpDanhGia, iDKSan);
        }
        private void btnVietDanhGia_Click(object sender, EventArgs e)
        {
            this.Hide();
            VietDanhGia f = new VietDanhGia(iDKSan);
            f.ShowDialog();
            f = null;
            this.Close();
        }
        public void ReLoadData()
        {
            dGia.LoadDataDanhGia(flpDanhGia, iDKSan);
        }
    }
}
