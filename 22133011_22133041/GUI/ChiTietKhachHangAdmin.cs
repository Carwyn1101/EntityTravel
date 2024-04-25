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
    public partial class ChiTietKhachHangAdmin : Form
    {
        HoaDonDAO hoaDonDAO = new HoaDonDAO();
        public ChiTietKhachHangAdmin()
        {
            InitializeComponent();
        }

        private void btnThoát_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChiTietKhachHangAdmin_Load(object sender, EventArgs e)
        {
            hoaDonDAO.LoadData(this);
        }
    }
}
