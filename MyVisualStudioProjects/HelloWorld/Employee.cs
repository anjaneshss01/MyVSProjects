using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Employee
    {
        public int EmpID { get; set; }
        public String EmpName { get; set; }

        public void GetEmpInfo()
        {
            Console.WriteLine("Employee ID : {0} and Name : {1}", EmpID, EmpName);
        }
    }
}
