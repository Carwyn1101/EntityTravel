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
        DanhGiaDAO dGia = new DanhGiaDAO();
        public DanhGiaCuaKhachHang()
        {
            InitializeComponent();            
        }      
        private void DanhGiaCuaKhachHang_Load(object sender, EventArgs e)
        {
            dGia.LoadDataDanhGia(flpDanhGia, Program.iDKhachSanInstance);
        }
        private void btnVietDanhGia_Click(object sender, EventArgs e)
        {
            this.Hide();
            VietDanhGia f = new VietDanhGia(Program.iDKhachSanInstance);
            f.ShowDialog();
            f = null;
            this.Close();
        }
        public void ReLoadData()
        {
            dGia.LoadDataDanhGia(flpDanhGia, Program.iDKhachSanInstance);
        }
    }
}
