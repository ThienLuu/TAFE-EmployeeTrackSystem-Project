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
    public class EmployeeHoursController
    {
        private EmployeeHoursDAO dao;

        public EmployeeHoursController()
        {
            dao = new EmployeeHoursDAO();
        }

        //Add employee hours
        public void AddHours(EmployeeHours empHrs)
        {
            dao.InsertEmpHours(empHrs);
        }

        //Select employee by ID
        public Result<EmployeeHours> SelectByIDHours(int id)
        {
            Result<EmployeeHours> theResults = new Result<EmployeeHours>();
            try
            {
                theResults.Data = dao.SelectEmpIDHours(id);
                //Report
                theResults.Status = ResultEnumCheck.Success;
            }
            catch (Exception ex)
            {
                //Logging to the output window
                Console.WriteLine("Error in EmployeeHoursController/SelectByIDHours : " + ex.Message);
                //Report
                theResults.Status = ResultEnumCheck.Fail;
            }

            return theResults;
        }
    }
}