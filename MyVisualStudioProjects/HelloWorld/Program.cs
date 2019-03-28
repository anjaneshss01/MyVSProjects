using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World");
            //Console.WriteLine("Welcome to Git"); //Changes for Git Testings

            Console.Read();

            Employee e = new Employee();
            e.EmpID = 101;
            e.EmpName = "Vinod";

            e.GetEmpInfo();

            Console.WriteLine("TEst output")

        }
    }
}
