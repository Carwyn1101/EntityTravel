using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace GUI
{
    public partial class ChiTietPhongCuaKhachSanUser : Form
    {        
        ThongTinPhongKhachSanDAO pKSanDAO = new ThongTinPhongKhachSanDAO();
        ThongTinKhachHangDAO kHangDAO = new ThongTinKhachHangDAO();
        HoaDonDAO hoaDonDAO = new HoaDonDAO();
        DatPhongDAO datPhongDAO = new DatPhongDAO();
        UuDaiDAO uuDaiDAO = new UuDaiDAO();
        CheckGiaTri check = new CheckGiaTri();
        int stt; string tmpTongTien;private int soLanAnBtnThue = 0, soLanAnBtnThanhToan = 0, soLanAnBtnLuu = 0;     
        public ChiTietPhongCuaKhachSanUser()
        {
            InitializeComponent();           
        }
        private void ChiTietPhongCuaKhachSanUser_Load(object sender, EventArgs e)
        {
            pKSanDAO.LoadChiTietPhongUser(this, Program.iDPhongInstance);
        }
        private void btnThue_Click(object sender, EventArgs e)
        {        
            if(soLanAnBtnThue==0)
            {
                this.Width += 418;
                panelHoaDon.Visible = false;
                panelKhachHang.Visible = true;
                panelKhachHang.Location = new Point(panelHoaDon.Location.X, panelHoaDon.Location.Y);
                soLanAnBtnThue++;
            }        
        }
        private void btnChuyenTiep_Click(object sender, EventArgs e)
        {
            if (soLanAnBtnLuu==0)
            {
                if (check.CheckValid(panelKhachHang))
                {
                    if (check.ValidPhoneNumber(txtSoDienThoai.Text))
                    {
                        if (check.ValidEmail(txtMail.Text))
                        {
                            ThongTinKhachHang kHang = new ThongTinKhachHang();
                            kHang.IDKhachHang = Program.iDTaiKhoanInstance;
                            kHang.TenKhachHang = txtTenKhachHang.Text;
                            kHang.SDT = txtSoDienThoai.Text;
                            kHang.CCCD = txtCCCD.Text;
                            kHang.Mail = txtMail.Text;
                            kHangDAO.Them(kHang);
                            stt = kHang.SoThuTu;
                            txtTenKhachHangHD.Text = txtTenKhachHang.Text;
                            txtSoDienThoaiHD.Text = kHang.SDT;
                            txtCCCDHD.Text = kHang.CCCD;
                            txtMailHD.Text = kHang.Mail;
                            txtNgayNhanPhong.Text = Program.ngayNhanInstance.ToString("yyyy-MM-dd");
                            txtNgayTraPhong.Text = Program.ngayTraInstance.ToString("yyyy-MM-dd");
                            TinhTongTien();
                            panelKhachHang.Visible = false;
                            panelHoaDon.Visible = true;
                            soLanAnBtnLuu++;
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
        private void txtUuDai_TextChanged(object sender, EventArgs e)
        {
            txtTongTienThanhToan.Text = tmpTongTien;
        }
        private void btnDungVoucher_Click(object sender, EventArgs e)
        {
            if (txtTongTienThanhToan.Text != tmpTongTien) txtTongTienThanhToan.Text = tmpTongTien;
            int? tmp = uuDaiDAO.LoadGiaTriVoucher(Program.iDKhachSanInstance, txtUuDai.Text);
            decimal tienGiam = decimal.Parse(txtTongTienThanhToan.Text) * (decimal)tmp / 100;
            txtTongTienThanhToan.Text = (decimal.Parse(txtTongTienThanhToan.Text) - tienGiam).ToString("N0");
        }
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if(soLanAnBtnThanhToan==0)
            {
                HoaDon hd = new HoaDon();
                hd.SoThuTuKhachHang = stt;
                hd.TenKhachHang = txtTenKhachHang.Text;
                hd.SDT = txtSoDienThoai.Text;
                hd.CCCD = txtCCCD.Text;
                hd.Mail = txtMail.Text;
                hd.NgayDatPhong = DateTime.Now;
                hd.NgayNhanPhong = DateTime.ParseExact(txtNgayNhanPhong.Text, "yyyy-MM-dd", CultureInfo.InvariantCulture);
                hd.NgayTraPhong = DateTime.ParseExact(txtNgayTraPhong.Text, "yyyy-MM-dd", CultureInfo.InvariantCulture);
                hd.TongTien = txtTongTienThanhToan.Text;
                hd.IDPhong = Program.iDPhongInstance;

                hoaDonDAO.Them(hd);
                DatPhong dp = new DatPhong();
                dp.NgayNhanPhong = DateTime.ParseExact(txtNgayNhanPhong.Text, "yyyy-MM-dd", CultureInfo.InvariantCulture);
                dp.NgayTraPhong = DateTime.ParseExact(txtNgayTraPhong.Text, "yyyy-MM-dd", CultureInfo.InvariantCulture);
                dp.IDPhong = Program.iDPhongInstance;
                dp.IDKhachSan = Program.iDKhachSanInstance;
                dp.IDKhachHang = Program.iDTaiKhoanInstance;
                datPhongDAO.Them(dp);            
                soLanAnBtnThanhToan++;
            }    
        }
        private void TinhTongTien()
        {
            DateTime tmpNgayNhanPhong = DateTime.ParseExact(txtNgayNhanPhong.Text, "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime tmpNgayTraPhong = DateTime.ParseExact(txtNgayTraPhong.Text, "yyyy-MM-dd", CultureInfo.InvariantCulture);
            TimeSpan khoangThoiGianThue = tmpNgayTraPhong - tmpNgayNhanPhong;
            int soNgayThue = khoangThoiGianThue.Days;
            decimal giaPhong = decimal.Parse(lblGiaPhong.Text);
            decimal tongTien = soNgayThue * giaPhong;
            txtTongTienThanhToan.Text = tongTien.ToString("N0");
            tmpTongTien = txtTongTienThanhToan.Text;
        }
    }
}
