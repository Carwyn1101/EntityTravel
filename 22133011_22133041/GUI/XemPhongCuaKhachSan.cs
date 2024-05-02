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
        ThongTinPhongKhachSanDAO pKSanDAO = new ThongTinPhongKhachSanDAO();
        DatPhongDAO datPhongDAO = new DatPhongDAO();   
        CheckGiaTri check = new CheckGiaTri();
        public XemPhongCuaKhachSan()
        {
            InitializeComponent();
        }
        public XemPhongCuaKhachSan(int iDKhachSan)
        {
            InitializeComponent();           
            flpTrangChuKhachSan.Controls.Clear();
            //pKSanDAO.LoadDanhSachPhongUser(flpTrangChuKhachSan, Program.iDKhachSanInstance);
            Program.XemPhongCuaKhachSanInstance = this;
            dtpNgayNhanPhong.Value = DateTime.Now;
            dtpNgayTraPhong.Value = DateTime.Now;
        }     
        public void ReLoad()
        {
            pKSanDAO.LoadDanhSachPhongUser(flpTrangChuKhachSan, Program.iDKhachSanInstance);
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if(check.NgayCheckIn(dtpNgayNhanPhong.Value))
            {
                if(check.NgayCheckOut(dtpNgayNhanPhong.Value, dtpNgayTraPhong.Value))
                {
                    flpTrangChuKhachSan.Controls.Clear();
                    Program.ngayNhanInstance = dtpNgayNhanPhong.Value;
                    Program.ngayTraInstance = dtpNgayTraPhong.Value;
                    datPhongDAO.LoadPhongTrong(Program.ngayNhanInstance, Program.ngayTraInstance, flpTrangChuKhachSan);
                } 
                else
                {
                    MessageBox.Show("Ngày trả phòng không hợp lệ, vui lòng nhập lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ngày nhận phòng không hợp lệ, vui lòng nhập lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }
    }
}
