using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GUI
{
    public partial class ThemUuDai : Form
    {
        UuDaiDAO uuDaiDAO = new UuDaiDAO();
        CheckGiaTri check = new CheckGiaTri();
        public ThemUuDai()
        {
            InitializeComponent();
            ReLoad();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if(check.CheckValid(this))
            {
                MaGiamGia maGiamGia = new MaGiamGia();
                maGiamGia.MaGiam = txtMaGiamGia.Text;
                maGiamGia.GiaTri = int.Parse(cboGiaTriMa.Text);
                maGiamGia.IDKhachSan = Program.iDKhachSanInstance;
                uuDaiDAO.ThemUuDai(maGiamGia);
                ReLoad();
            }
            else
            {
                MessageBox.Show("Không được để trống, vui lòng nhập dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            int soMa = Convert.ToInt32(dtgvDanhSachMaGiam.SelectedCells[0].OwningRow.Cells["STTMa"].Value.ToString());
            uuDaiDAO.XoaUuDai(soMa);
            ReLoad();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            int soMa = Convert.ToInt32(dtgvDanhSachMaGiam.SelectedCells[0].OwningRow.Cells["STTMa"].Value.ToString());
            uuDaiDAO.SuaUuDai(this, soMa);
            ReLoad();
        }
        public void ReLoad()
        {
            uuDaiDAO.Load(this, Program.iDKhachSanInstance);
            uuDaiDAO.AddBinding(this);
        }
    }
}
