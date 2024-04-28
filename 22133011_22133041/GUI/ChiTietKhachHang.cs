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
        CheckGiaTri check = new CheckGiaTri();
        public ChiTietKhachHang()
        {
            InitializeComponent();
        }
        private void btnChuyenTiep_Click(object sender, EventArgs e)
        {
            if(check.CheckValid(this))
            {
                if (check.ValidPhoneNumber(txtSoDienThoai.Text))
                {
                    if (check.ValidEmail(txtMail.Text))
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
                        MessageBox.Show("Email không hợp lệ, vui lòng nhập lại email", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Số điện thoại không hợp lệ, vui lòng nhập lại theo dạng 0xxxxxxxxx", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }    
            }
            else
            {
                MessageBox.Show("Không được để trống, vui lòng nhập dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }          
        }
    }
}
