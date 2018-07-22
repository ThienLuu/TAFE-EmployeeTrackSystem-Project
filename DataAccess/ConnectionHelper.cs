using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    class ConnectionHelper
    {
        public static string getConnectionString()
        {
            // -=#=- HOME - School Laptop -=#=-
            return "Data Source=CND5103DZ8\\THIENLUUTAFE;Initial Catalog=\"Tracking Employee Work Hours\";Integrated Security=True";

            // -=#=- TAFE Shanti's Class - Computer ## -=#=-
            //return "Data Source=PEA104-19\\SQL2014;Initial Catalog=\"Tracking Employee Work Hours\";Integrated Security=True";

            // -=#=- TAFE Alaa's Class - Computer #17 -=#=-
            //return "Data Source=PEA106-17;Initial Catalog=\"Tracking Employee Work Hours\";Integrated Security=True";

            // -=#=- Other -=#=-
            //return "[Insert here]";
        }
    }
}
