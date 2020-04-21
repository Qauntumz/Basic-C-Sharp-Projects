using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_pg_169
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            /*            string FirstName = "Sample";
                        string LastName = "Student";*/
            employee.FirstName = "Sample";
            employee.LastName = "Student";

            employee.sayName();
        }
    }
}
