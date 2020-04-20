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
            string FirstName = "Sample";
            string LastName = "Student";
            employee.sayName(FirstName, LastName);
        }
    }
}
