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
    public partial class UCChuaHoanThanh : UserControl
    {
        int maDatPhong;
        DatPhongDAO dpDAO = new DatPhongDAO();
        public UCChuaHoanThanh()
        {
            InitializeComponent();
        }
        public UCChuaHoanThanh(string tenKhachSan, string tenPhong, DateTime ngayNhan, DateTime ngayTra, int maDatPhong)
        {
            InitializeComponent();
            lblTenKhachSan.Text = tenKhachSan;
            lblTenPhong.Text = tenPhong;
            lblNgayNhan.Text = ngayNhan.ToString("dd/MM/yyyy");
            lblNgayTra.Text = ngayTra.ToString("dd/MM/yyyy");
            this.maDatPhong = maDatPhong;
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            dpDAO.Xoa(maDatPhong); 
            Program.LichSuBookInstance.Controls.Clear();
            LichSuBook f = new LichSuBook();
            f.ShowDialog();
        }
    }
}
