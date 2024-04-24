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
    public partial class UCHoanThanh : UserControl
    {
       
        public UCHoanThanh()
        {
            InitializeComponent();
        }
        public UCHoanThanh(string tenKhachSan, string tenPhong, DateTime ngayNhan, DateTime ngayTra)
        {
            InitializeComponent();
            lblTenKhachSan.Text = tenKhachSan;
            lblTenPhong.Text = tenPhong;
            lblNgayNhan.Text = ngayNhan.ToString("dd/MM/yyyy");
            lblNgayTra.Text = ngayTra.ToString("dd/MM/yyyy");
            
        }
    }
}
