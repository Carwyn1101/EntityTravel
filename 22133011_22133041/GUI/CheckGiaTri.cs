using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    internal class CheckGiaTri
    {
        public bool ValidTextBoxIsNotNullOrWhitespace(Guna2TextBox textBox)
        {
            return !string.IsNullOrWhiteSpace(textBox.Text);
        }
        public bool ValidRichTextBoxIsNotNullOrWhitespace(RichTextBox rtextBox)
        {
            return !string.IsNullOrWhiteSpace(rtextBox.Text);
        }

        public bool ValidComboBoxIsNotNullOrWhitespace(ComboBox cbBox)
        {
            return !string.IsNullOrWhiteSpace(cbBox.Text);
        }
        public bool ValidPictureBoxIsNotNullOrWhitespace(PictureBox pictureBox)
        {           
            return !(pictureBox.Image == null);
        }
        public bool ValidPhoneNumber(string phoneNumber)
        {
            //Kiểm tra số điện thoại có 10 chữ số và bắt đầu bằng số 0

            phoneNumber = phoneNumber.Replace(" ", "").Replace("-", "");

            if (phoneNumber.Length != 10)
            {
                return false;
            }

            if (!phoneNumber.StartsWith("0"))
            {
                return false;
            }

            foreach (char c in phoneNumber)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }
        public bool ValidEmail(string email)
        {
            // Biểu thức chính quy để kiểm tra định dạng email
            string emailPattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";

            // Kiểm tra email sử dụng biểu thức chính quy
            return Regex.IsMatch(email, emailPattern);
        }
        public bool NgayCheckOut(DateTime ngayNhanPhong, DateTime ngayTraPhong)
        {
            return ngayTraPhong > ngayNhanPhong;
        }
        public bool NgayCheckIn(DateTime ngayNhanPhong)
        {
            DateTime currentTime = DateTime.Now;
            return ngayNhanPhong.Date >= currentTime.Date;
        }
        public bool CheckValid(Control parentControl)
        {
            bool valid = true;

            foreach (Control control in parentControl.Controls)
            {
                if (control is Guna2TextBox textBox)
                {
                    if (!ValidTextBoxIsNotNullOrWhitespace(textBox))
                    {
                        valid = false;
                        break;
                    }
                }
                else if (control is ComboBox cbBox)
                {
                    if (!ValidComboBoxIsNotNullOrWhitespace(cbBox))
                    {
                        valid = false;
                        break;
                    }
                }
                else if (control is PictureBox pictureBox)
                {
                    if (!ValidPictureBoxIsNotNullOrWhitespace(pictureBox))
                    {
                        valid = false;
                        break;
                    }
                }
                else if (control is RichTextBox rtextBox)
                {
                    if (!ValidRichTextBoxIsNotNullOrWhitespace(rtextBox))
                    {
                        valid = false;
                        break;
                    }
                }
                else if (!CheckValid(control))
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }       
    }
}
