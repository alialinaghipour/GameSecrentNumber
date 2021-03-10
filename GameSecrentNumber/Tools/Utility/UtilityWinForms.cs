using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tools.Utility
{
    public class UtilityWinForms
    {
        public void ShowMeesage(string text, string caption, MessageBoxButtons boxButtons = MessageBoxButtons.OK, MessageBoxIcon boxIcon = MessageBoxIcon.Information)
        {
            MessageBox.Show(text, caption, boxButtons, boxIcon);
        }
    }
}
