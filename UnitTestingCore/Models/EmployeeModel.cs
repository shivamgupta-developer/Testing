using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnitTestingCore.Models
{
    public class EmployeeModel : IEmployeeInterface
    {
       public string GetEmployeeById(int id)
        {
            string EmployeeName;
            if (id == 1)
            {
                EmployeeName = "Rahul";
            }
            else if (id == 2)
            {
                EmployeeName = "Rishap";
            }
            else if (id == 3)
            {
                EmployeeName = "Laxmi";
            }
            else if (id == 4)
            {
                EmployeeName = "Shivam";
            }
            else if (id == 5)
            {
                EmployeeName = "Hardik";
            }
            else 
            {
             EmployeeName = null;
            }
            return EmployeeName;
        }
    }
}
