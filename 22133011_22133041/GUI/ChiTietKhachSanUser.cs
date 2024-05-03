using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace GUI
{
    public partial class ChiTietKhachSanUser : Form
    {        
        ThongTinKhachSanDAO kSanDAO = new ThongTinKhachSanDAO();
        CheckGiaTri check = new CheckGiaTri();
        DatPhongDAO datPhongDAO = new DatPhongDAO();
        bool[] tieuChiLoc = new bool[9];
        public ChiTietKhachSanUser()
        {
            InitializeComponent();
        }                     
        private void ChiTietKhachSanUser_Load(object sender, EventArgs e)
        {
            kSanDAO.LoadChiTietKhachSanUser(this, Program.iDKhachSanInstance);
            dtpNgayNhanPhong.Value = DateTime.Now;
            dtpNgayTraPhong.Value = DateTime.Now;
        }                       
        private void ResetCheckBoxes()
        {
            checkBoxPhoBien1.Checked = false;
            checkBoxPhoBien2.Checked = false;
            checkBoxPhoBien3.Checked = false;
            checkBoxPhoBien4.Checked = false;
            checkBoxHuongTamNhin1.Checked = false;
            checkBoxHuongTamNhin2.Checked = false;
            checkBoxTienNghi1.Checked = false;
            checkBoxTienNghi2.Checked = false;
            checkBoxTienNghi3.Checked = false;
            for (int i = 0; i < tieuChiLoc.Length; i++)
            {
                tieuChiLoc[i] = false;
            }
        }     
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (check.NgayCheckIn(dtpNgayNhanPhong.Value))
            {
                if (check.NgayCheckOut(dtpNgayNhanPhong.Value, dtpNgayTraPhong.Value))
                {
                    flpTrangChuKhachSan.Controls.Clear();
                    Program.ngayNhanInstance = dtpNgayNhanPhong.Value;
                    Program.ngayTraInstance = dtpNgayTraPhong.Value;
                    if (tieuChiLoc.Any(x => x))
                    {
                        datPhongDAO.LoadPhongTrongVoiTieuChiLoc(Program.ngayNhanInstance, Program.ngayTraInstance, flpTrangChuKhachSan, tieuChiLoc);
                        ResetCheckBoxes();
                        dtpNgayNhanPhong.Value = DateTime.Now;
                        dtpNgayTraPhong.Value = DateTime.Now;
                    }
                    else
                    {
                        datPhongDAO.LoadPhongTrong(Program.ngayNhanInstance, Program.ngayTraInstance, flpTrangChuKhachSan);
                    }
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
        private void linklbDanhGia_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DanhGiaCuaKhachHang f = new DanhGiaCuaKhachHang();
            f.ShowDialog();
        }      
        private void HandleCheckBoxCheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkbox = sender as CheckBox;
            if (checkbox != null && checkbox.Checked)
            {
                int index = int.Parse(checkbox.Tag.ToString());
                tieuChiLoc[index] = true;
            }
        }
        private void checkBoxPhoBien1_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxPhoBien1.Tag = 0;
            if (checkBoxPhoBien1.Checked)
            {
                HandleCheckBoxCheckedChanged(sender, e);
            }
        }
        private void checkBoxPhoBien2_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxPhoBien2.Tag = 1;
            if (checkBoxPhoBien2.Checked)
            {
                HandleCheckBoxCheckedChanged(sender, e);
            }
        }
        private void checkBoxPhoBien3_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxPhoBien3.Tag = 2;
            if (checkBoxPhoBien3.Checked)
            {
                HandleCheckBoxCheckedChanged(sender, e);
            }
        }
        private void checkBoxPhoBien4_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxPhoBien4.Tag = 3;
            if (checkBoxPhoBien4.Checked)
            {
                HandleCheckBoxCheckedChanged(sender, e);
            }
        }

        private void checkBoxHuongTamNhin1_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxHuongTamNhin1.Tag = 4;
            if (checkBoxHuongTamNhin1.Checked)
            {
                HandleCheckBoxCheckedChanged(sender, e);
            }
        }

        private void checkBoxHuongTamNhin2_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxHuongTamNhin2.Tag = 5;
            if (checkBoxHuongTamNhin1.Checked)
            {
                HandleCheckBoxCheckedChanged(sender, e);
            }
        }
        private void checkBoxTienNghi1_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxTienNghi1.Tag = 6;
            if (checkBoxTienNghi1.Checked)
            {
                HandleCheckBoxCheckedChanged(sender, e);
            }
        }
        private void checkBoxTienNghi2_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxTienNghi2.Tag = 7;
            if (checkBoxTienNghi2.Checked)
            {
                HandleCheckBoxCheckedChanged(sender, e);
            }
        }
        private void checkBoxTienNghi3_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxTienNghi3.Tag = 8;
            if (checkBoxTienNghi3.Checked)
            {
                HandleCheckBoxCheckedChanged(sender, e);
            }
        }
    }
}
