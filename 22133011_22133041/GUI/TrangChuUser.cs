using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class TrangChuUser : Form
    {
        ThongTinKhachSanDAO kSanDAO = new ThongTinKhachSanDAO();
        DatPhongDAO dPDAO = new DatPhongDAO();
        bool logOut;
        public TrangChuUser()
        {
            InitializeComponent();
        }
        public TrangChuUser(string tenDangNhap, int iDNguoiDung)
        {
            InitializeComponent();
            lblTenTaiKhoan.Text = tenDangNhap;
        }
        private void TrangChuUser_Load(object sender, EventArgs e)
        {
            dPDAO.TrangThaiLoad(sender,e);
            kSanDAO.GetAllKhachSan(flpTrangChuUser);
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            flpTrangChuUser.Controls.Clear();
            string diaDiem = cboDiaDiemTimKiem.Text;
            kSanDAO.SearchKhachSanByDiaDiem(flpTrangChuUser, diaDiem);
        }
        private void pic_DangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                logOut = true; // Đánh dấu đã đăng xuất
                this.Hide();
                DangNhap f = new DangNhap(logOut);
                f.ShowDialog();
                f = null;
                this.Close(); // Đóng form đăng nhập khi đã đăng xuất
            }
        }
        public void ReLoad()
        {
            kSanDAO.GetAllKhachSan(flpTrangChuUser);
        }
        private void btnLichSuBook_Click(object sender, EventArgs e)
        {
            LichSuBook f = new LichSuBook();
            Program.LichSuBookInstance = f;
            f.ShowDialog();            
        }
    }
}
