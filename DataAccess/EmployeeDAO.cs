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
    public class EmployeeDAO
    {
        //Insert a employee
        public void InsertEmp(Employee emp)
        {
            //1 - Connection
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConnectionHelper.getConnectionString();
            conn.Open();

            using (conn)
            {
                //2 - Command
                SqlCommand command = new SqlCommand("sp_Employees_InsertEmployee", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                //Parameters
                command.Parameters.Add(new SqlParameter("@firstName", emp.FirstName));
                command.Parameters.Add(new SqlParameter("@lastName", emp.LastName));
                command.Parameters.Add(new SqlParameter("@email", emp.Email));
                command.Parameters.Add(new SqlParameter("@dob", emp.DOB));
                command.Parameters.Add(new SqlParameter("@phone", emp.Phone));

                //3 - Run command
                command.ExecuteNonQuery();
            }
        }

        //Update employee
        public void UpdateEmp(Employee emp)
        {
            //1 - Connection
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConnectionHelper.getConnectionString();
            conn.Open();

            using (conn)
            {
                //2 - Command
                SqlCommand command = new SqlCommand("sp_Employees_UpdateEmployee", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                //params
                command.Parameters.Add(new SqlParameter("@firstName", emp.FirstName));
                command.Parameters.Add(new SqlParameter("@lastName", emp.LastName));
                command.Parameters.Add(new SqlParameter("@email", emp.Email));
                command.Parameters.Add(new SqlParameter("@dob", emp.DOB));
                command.Parameters.Add(new SqlParameter("@phone", emp.Phone));
                command.Parameters.Add(new SqlParameter("@empID", emp.ID));

                //3 - Run command
                command.ExecuteNonQuery();
            }
        }

        //Select all employee
        public List<Employee> SelectAllEmp()
        {
            //1 - Connection
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConnectionHelper.getConnectionString();
            conn.Open();

            using (conn)
            {
                //2 - Command
                SqlCommand command = new SqlCommand("sp_Employees_SelectAllEmployees", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                //3 - Run command
                SqlDataReader reader = command.ExecuteReader();

                //4 - Reads rows and into employee objects then add them to the list
                List<Employee> list = new List<Employee>();

                //Read method return true or false - moves reader pointer into the next row
                while (reader.Read())
                {
                    Employee newEmp = new Employee();
                    newEmp.ID = Convert.ToInt32(reader["EmpID"]);
                    newEmp.FirstName = Convert.ToString(reader["FirstName"]);
                    newEmp.LastName = Convert.ToString(reader["LastName"]);
                    newEmp.Email = Convert.ToString(reader["Email"]);
                    newEmp.DOB = Convert.ToDateTime(reader["DOB"]);
                    newEmp.Phone = Convert.ToString(reader["Phone"]);
                    list.Add(newEmp);
                }

                return list;
            }
        }

        //Select employee by ID
        public List<Employee> SelectEmpByID(int id)
        {
            //1- connection
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConnectionHelper.getConnectionString();
            conn.Open();

            using (conn)
            {
                //2 - Command
                SqlCommand command = new SqlCommand("sp_Employees_SelectEmployeeByID", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                //3a - Run command (send)
                command.Parameters.Add(new SqlParameter("@empID", id));

                //3b - Run command (read)
                SqlDataReader reader = command.ExecuteReader();

                //4 - Reads rows and into employee objects then add them to the list
                List<Employee> emp = new List<Employee>();

                //Read method return true or false - moves reader pointer into the next row
                while (reader.Read())
                {
                    Employee newEmp = new Employee();
                    newEmp.ID = Convert.ToInt32(reader["EmpID"]);
                    newEmp.FirstName = Convert.ToString(reader["FirstName"]);
                    newEmp.LastName = Convert.ToString(reader["LastName"]);
                    newEmp.Email = Convert.ToString(reader["Email"]);
                    newEmp.DOB = Convert.ToDateTime(reader["DOB"]);
                    newEmp.Phone = Convert.ToString(reader["Phone"]);
                    emp.Add(newEmp);
                }

                return emp;
            }
        }

        //Select employee by Email
        public List<Employee> SelectEmpByEmail(string email)
        {
            //1- connection
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConnectionHelper.getConnectionString();
            conn.Open();

            using (conn)
            {
                //2 - Command
                SqlCommand command = new SqlCommand("sp_Employees_SelectEmployeeByEmail", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                //3a - Run command (send)
                command.Parameters.Add(new SqlParameter("@email", email));

                //3b - Run command (read)
                SqlDataReader reader = command.ExecuteReader();

                //4 - Reads rows then into employee objects then add them to the list
                List<Employee> emp = new List<Employee>();

                //Read method return true or false - moves reader pointer into the next row
                while (reader.Read())
                {
                    Employee newEmp = new Employee();
                    newEmp.ID = Convert.ToInt32(reader["EmpID"]);
                    newEmp.FirstName = Convert.ToString(reader["FirstName"]);
                    newEmp.LastName = Convert.ToString(reader["LastName"]);
                    newEmp.Email = Convert.ToString(reader["Email"]);
                    newEmp.DOB = Convert.ToDateTime(reader["DOB"]);
                    newEmp.Phone = Convert.ToString(reader["Phone"]);
                    emp.Add(newEmp);
                }

                return emp;
            }
        }
    }
}
