using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View
{
     static class ErrorMessage
    {
        public static void InputMessage()
        {
            System.Windows.Forms.MessageBox.Show("Error - Incorrect or empty input field(s)");
        }

        public static void CannotRetrieve()
        {
            System.Windows.Forms.MessageBox.Show("Cannot get employees. Please check connection");
        }

        public static string Length()
        {
            return "Too long";
        }

        public static string InvalidPhNo()
        {
            return "Invalid phone number";
        }
    }
}
