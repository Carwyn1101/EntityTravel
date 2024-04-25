using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class ChiTietPhongCuaKhachSanAdmin : Form
    {
        string tenAnh1, tenAnh2;     
        ThongTinKhachSanDAO kSanDAO = new ThongTinKhachSanDAO();
        ThongTinPhongKhachSanDAO pKSanDAO = new ThongTinPhongKhachSanDAO();
        string tmpGiaPhong;
        public ChiTietPhongCuaKhachSanAdmin()
        {
            InitializeComponent();
        }           
        private void btnSuaAnh1_Click(object sender, EventArgs e)
        {
            kSanDAO.SaveImage(pic_Anh1, out tenAnh1);
        }    
        private void btnSuaAnh2_Click(object sender, EventArgs e)
        {
            kSanDAO.SaveImage(pic_Anh2, out tenAnh2);
        }
        private void ChiTietPhongCuaKhachSanAdmin_Load(object sender, EventArgs e)
        {
            pKSanDAO.LoadChiTietPhongAdmin(this, Program.iDPhongInstance, out tenAnh1, out tenAnh2);
            tmpGiaPhong = txtGiaPhong.Text;
        }       
        public void TinhTien()
        {               
                decimal uuDai = decimal.Parse(txtUuDai.Text);
                decimal giaPhong = decimal.Parse(txtGiaPhong.Text);
                decimal giaSauUuDai = giaPhong - ((uuDai * giaPhong) / 100);
                string tmp1 = giaSauUuDai.ToString("N0");
                txtGiaPhong.Text = tmp1;          
        }
        private void linklbUuDai_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtGiaPhong.Text = tmpGiaPhong;
            if (txtTrangThai.Text == "Còn Trống")
            {
                if (string.IsNullOrEmpty(txtUuDai.Text))
                {                    
                    MessageBox.Show("Bạn chưa nhập ưu đãi");
                    txtGiaPhong.Text = tmpGiaPhong;
                }
                else
                TinhTien();
            }
            else
            {
                MessageBox.Show("Phòng hiện tại đang có khách thuê nên chưa thể cập nhật");
            }
        }
        private void linklbChiTiet_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(txtTrangThai.Text == "Còn Trống")
            {
                MessageBox.Show("Phòng hiện tại không có khách thuê");
            }
            else
            {               
                ChiTietKhachHangAdmin f = new ChiTietKhachHangAdmin();
                f.ShowDialog();
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            pKSanDAO.Xoa(Program.iDPhongInstance);
            this.Hide();
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            ThongTinPhongCuaKhachSan kSan = new ThongTinPhongCuaKhachSan();
            kSan.IDPhong = Program.iDPhongInstance;
            kSan.TenPhong = cboTenPhong.Text;
            kSan.KichThuocPhong = txtKichThuocPhong.Text;
            kSan.GiaPhong = txtGiaPhong.Text;
            kSan.TienNghiPhongTam1 = cboTienNghiPhongTam1.Text;
            kSan.TienNghiPhongTam2 = cboTienNghiPhongTam2.Text;
            kSan.TienNghiPhongTam3 = cboTienNghiPhongTam3.Text;
            kSan.TienNghiPhongTam4 = cboTienNghiPhongTam4.Text;
            kSan.HuongTamNhin1 = cboHuongTamNhin1.Text;
            kSan.HuongTamNhin2 = cboHuongTamNhin2.Text;
            kSan.TienNghiPhong1 = cboTienNghiPhong1.Text;
            kSan.TienNghiPhong2 = cboTienNghiPhong2.Text;
            kSan.TienNghiPhong3 = cboTienNghiPhong3.Text;
            kSan.TienNghiPhong4 = cboTienNghiPhong4.Text;
            kSan.TienNghiPhong5 = cboTienNghiPhong5.Text;
            kSan.TienNghiPhong6 = cboTienNghiPhong6.Text;
            kSan.HutThuoc1 = cboHutThuoc1.Text;
            kSan.HutThuoc2 = cboHutThuoc2.Text;
            kSan.UuDai = txtUuDai.Text;
            kSan.TrangThai = txtTrangThai.Text;
            kSan.HinhAnh1 = tenAnh1;
            kSan.HinhAnh2 = tenAnh2;
            pKSanDAO.Sua(kSan);
            this.Close();
            Program.flpPhongInstance.Controls.Clear();
            pKSanDAO.LoadDanhSachPhongAdmin(Program.flpPhongInstance, Program.iDKhachSanInstance);
        }
    }
}
