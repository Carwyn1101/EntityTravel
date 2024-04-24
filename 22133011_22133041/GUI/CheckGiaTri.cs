using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    internal class CheckGiaTri
    {
        ErrorProvider errorProvider = new ErrorProvider();
        bool ValidateIsNotNullOrWhitespace(Guna2TextBox textBox)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                return true;
            }
            return false;
        }
        public bool AttachValidatingEventToTextBoxes(Control parentControl)
        {
            //bool valid = true;
            foreach (Control control in parentControl.Controls)
            {
                if (control is Guna2TextBox textBox)
                {
                    if (ValidateIsNotNullOrWhitespace(textBox))
                    {
                        //valid = false;
                        return false;
                    }
                }
                else if (control.HasChildren)
                {
                    AttachValidatingEventToTextBoxes(control); // Gọi đệ quy để duyệt qua tất cả các control con
                }
            }
            //return valid;
            return true;
        }
    }
}
