using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StaffManagement
{
   public class General
    {
        public static bool isNumber(KeyPressEventArgs e)
        {
            // If the entered character is not a control character and not a digit, then prevent the character from being entered
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                return true;
            } else {
                return false;
            }
        }
    }
}
