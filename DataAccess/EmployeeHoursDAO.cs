using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//...
using System.Data.SqlClient;
using Model;

namespace DataAccess
{
    public class EmployeeHoursDAO
    {
        //Add a employee hours
        public void InsertEmpHours(EmployeeHours empHrs)
        {
            //1 - Connection
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConnectionHelper.getConnectionString();
            conn.Open();

            using (conn)
            {
            //2 - Command
            SqlCommand command = new SqlCommand("sp_EmpHours_InsertEmployeeHours", conn);
            command.CommandType = System.Data.CommandType.StoredProcedure;

            //Parameters
            command.Parameters.Add(new SqlParameter("@empID", empHrs.EmpID));
            command.Parameters.Add(new SqlParameter("@workDate", empHrs.WorkDate));
            command.Parameters.Add(new SqlParameter("@hours", empHrs.Hours));

            //3 - Run command
            command.ExecuteNonQuery();
            }
        }

        //Search employee by ID
        public List<EmployeeHours> SelectEmpIDHours(int id)
        {
            //1- Connection
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConnectionHelper.getConnectionString();
            conn.Open();

            using (conn)
            {
                //2- Command
                SqlCommand command = new SqlCommand("sp_EmpHours_SelectEmployeeWorkDateAndHoursByID", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                //3a - Run command (send)
                command.Parameters.Add(new SqlParameter("@empID", id));

                //3b - run command (read)
                SqlDataReader reader = command.ExecuteReader();

                //4 - Reads rows and into employee objects then add them to the list
                List<EmployeeHours> empHrs = new List<EmployeeHours>();

                //Read method return true or false - moves reader pointer into the next row
                while (reader.Read())
                {
                    EmployeeHours newEmpHrs = new EmployeeHours();
                    newEmpHrs.WorkDate = Convert.ToDateTime(reader["WorkDate"]);
                    newEmpHrs.Hours = Convert.ToDecimal(reader["Hours"]);
                    empHrs.Add(newEmpHrs);
                }

                return empHrs;
            }
        }
    }
}
