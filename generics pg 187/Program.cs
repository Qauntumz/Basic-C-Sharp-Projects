using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operator_overload_184
{
    class Program
    {
        static void Main(string[] args)
        {
            Iquittable mployee = new Employee<string>();
            mployee.Quit();


            Employee<string> employee = new Employee<string>();
            employee.ID = 6;
            Employee<string> nployee = new Employee<string>();
            employee.FirstName = "Sample";
            employee.LastName = "Student";
            nployee.ID = 6;
            employee.sayName();
            /*            Console.WriteLine(nployee == employee);*/


            Employee<string> rployee = new Employee<string>();
            rployee.Things = new List<string>() { "thing 1", "thing 2", "thing 3", "thing 4" };

            Employee<int> kployee = new Employee<int>();
            kployee.Things = new List<int>() { 1, 2, 3, 4};

            foreach (string Things in rployee.Things)
            {
                Console.WriteLine(Things);
            }
            foreach (int Things in kployee.Things)
            {
                Console.WriteLine(Things);
            }
        }
    }
}
