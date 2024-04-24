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
            return !(cbBox.SelectedItem == null || string.IsNullOrWhiteSpace(cbBox.Text));
        }
        public bool ValidPictureBoxIsNotNullOrWhitespace(PictureBox pictureBox)
        {           
            return !(pictureBox.Image == null);
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
