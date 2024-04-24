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
    public partial class LichSuBook : Form
    {       
        DatPhongDAO dpDAO = new DatPhongDAO();
        public LichSuBook()
        {
            InitializeComponent();
        }
        private void LichSuBook_Load(object sender, EventArgs e)
        {
            dpDAO.LichSuBookLoad(flpLichSuBook);
        }      
    }   
}
