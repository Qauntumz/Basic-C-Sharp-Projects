using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_pg_176
{
    class Program
    {
        static void Main(string[] args)
        {
            Iquittable mployee = new Employee();
            mployee.Quit();
            

            Employee employee = new Employee();
            employee.ID = 7;
            Employee nployee = new Employee();
            employee.FirstName = "Sample";
            employee.LastName = "Student";
            nployee.ID = 7;
            employee.sayName();
            Console.WriteLine(nployee == employee);

        }
    }
}
