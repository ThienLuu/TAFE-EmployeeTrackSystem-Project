using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//...
using Model;
using DataAccess;

namespace Controller
{
    public class EmployeeController
    {
        private EmployeeDAO dao;

        public EmployeeController()
        {
            dao = new EmployeeDAO();
        }

        //Add Employee
        public void Add(Employee emp)
        {
            dao.InsertEmp(emp);
        }

        //Update Employee
        public ResultEnumCheck Update(Employee emp)
        {
            try
            {
                dao.UpdateEmp(emp);
                return ResultEnumCheck.Success;
            }
            catch (Exception ex)
            {
                //Logging to the output window
                Console.WriteLine("Error in EmployeeController/Update : " + ex.Message);
                //Report
                return ResultEnumCheck.Fail;
            }
        }

        //Select all employee
        public Result<Employee> SelectAll()
        {
            Result<Employee> theResults = new Result<Employee>();

            try
            {
                theResults.Data = dao.SelectAllEmp();
                //Report
                theResults.Status = ResultEnumCheck.Success;
            }
            catch (Exception ex)
            {
                //Logging to the output window
                Console.WriteLine("Error in EmployeeController/SelectAll : " + ex.Message);
                //Report
                theResults.Status = ResultEnumCheck.Fail;
            }

            return theResults;
        }

        //Select employee by ID
        public Result<Employee> SelectByID(int id)
        {
            Result<Employee> theResults = new Result<Employee>();
            try
            {
                theResults.Data = dao.SelectEmpByID(id);
                //Report
                theResults.Status = ResultEnumCheck.Success;
            }
            catch (Exception ex)
            {
                //logging to the output window
                Console.WriteLine("Error in EmployeeController/SelectByID : " + ex.Message);
                //Report
                theResults.Status = ResultEnumCheck.Fail;
            }

            return theResults;
        }

        //Select employee by email
        public Result<Employee> SelectByEmail(string email)
        {
            Result<Employee> theResults = new Result<Employee>();
            try
            {
                theResults.Data = dao.SelectEmpByEmail(email);
                //Report
                theResults.Status = ResultEnumCheck.Success;
            }
            catch (Exception ex)
            {
                //Logging to the output window
                Console.WriteLine("Error in EmployeeController/SelectByEmail : " + ex.Message);
                //Report
                theResults.Status = ResultEnumCheck.Fail;
            }

            return theResults;
        }
    }
}