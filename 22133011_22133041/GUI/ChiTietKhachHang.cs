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
    public partial class ChiTietKhachHang : Form
    {
        ThongTinKhachHangDAO kHangDAO = new ThongTinKhachHangDAO();
        ThongTinPhongKhachSanDAO pKSanDAO = new ThongTinPhongKhachSanDAO();
        CheckGiaTri check = new CheckGiaTri();
        public ChiTietKhachHang()
        {
            InitializeComponent();
        }
        private void btnChuyenTiep_Click(object sender, EventArgs e)
        {
            if(check.CheckValid(this))
            {
                this.Hide();
                ThongTinKhachHang kHang = new ThongTinKhachHang();
                kHang.IDKhachHang = Program.iDTaiKhoanInstance;
                kHang.TenKhachHang = txtTenKhachHang.Text;
                kHang.SDT = txtSoDienThoai.Text;
                kHang.CCCD = txtCCCD.Text;
                kHang.Mail = txtMail.Text;
                kHangDAO.Them(kHang);
                ChiTietHoaDon f = new ChiTietHoaDon(kHang);
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Không được để trống, vui lòng nhập dữ liệu", "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
    }
}
