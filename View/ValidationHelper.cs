using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//...
using System.Text.RegularExpressions;

namespace View
{
    public static class ValidationHelper
    {
        public static bool LettersOnly(string input)
        {
            if(input != "" && Regex.Match(input, "^[A-Za-z]{1}[a-z]*$").Success)
            {
                return true;
            }
            return false;
        }

        public static bool ValidPhone(string input)
        {
            if (Regex.Match(input, @"^[0-9]*$").Success)
            {
                return true;
            }
            return false;
        }

        public static bool IsNumber(string input)
        {
            if (Regex.Match(input, @"^\d*$").Success)
            {
                return true;
            }
            return false;
        }

        public static bool IsEmail(string input)
        {
            if (Regex.Match(input, @"^(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@"
     + @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
				[0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
     + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
				[0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|"
     + @"([a-zA-Z0-9]+[\w-]+\.)+[a-zA-Z]{1}[a-zA-Z0-9-]{1,23})$").Success)
            {
                return true;
            }
            return false;
        }

        public static bool DecimalHours(string input)
        {
            if (Regex.Match(input, @"^[0-9]+(\.[0-9]{1,2})?$").Success)
            {
                return true;
            }
            return false;
        }

        public static bool IsDate(string input)
        {
            if (Regex.Match(input, @"^(19[0-9][0-9]|20[0-4][0-9]|2050)[-/](0?[1-9]|1[0-2])[-/](0?[1-9]|[12][0-9]|3[01])").Success)
            {
                return true;
            }
            return false;
        }
    }
}
