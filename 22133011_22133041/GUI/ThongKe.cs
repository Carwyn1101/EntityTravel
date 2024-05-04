using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GUI
{
    public partial class ThongKe : Form
    {
        ThongTinKhachSanDAO kSDAO = new ThongTinKhachSanDAO();
        Chart chartDoanhThu = new Chart();
        public ThongKe()
        {
            InitializeComponent();
        }
        public void VeBieuDo(Dictionary<string, double> danhSachDoanhThu)
        {
            // Cấu hình biểu đồ
            chartDoanhThu.ChartAreas.Add("area");
            chartDoanhThu.Series.Add("doanhThu");
            chartDoanhThu.Series["doanhThu"].ChartType = SeriesChartType.Column;

            // Thêm dữ liệu vào biểu đồ
            foreach (var doanhThu in danhSachDoanhThu)
            {
                chartDoanhThu.Series["doanhThu"].Points.AddY(doanhThu.Value);
                chartDoanhThu.Series["doanhThu"].Points.Last().AxisLabel = doanhThu.Key;
            }

            // Hiển thị biểu đồ trên form
            chartDoanhThu.Dock = DockStyle.Fill;
            Controls.Add(chartDoanhThu);
        }
    }
}
