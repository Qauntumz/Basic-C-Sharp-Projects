using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_expressions_pg_202
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee() { FirstName = "Joe", LastName = "Smith", ID = 1 });
            employees.Add(new Employee() { FirstName = "Josh", LastName = "Smith", ID = 2 });
            employees.Add(new Employee() { FirstName = "Bill", LastName = "Blimser", ID = 3 });
            employees.Add(new Employee() { FirstName = "Bob", LastName = "Saget", ID = 4 });
            employees.Add(new Employee() { FirstName = "Amber", LastName = "White", ID = 5 });
            employees.Add(new Employee() { FirstName = "Zoe", LastName = "Budge", ID = 6 });
            employees.Add(new Employee() { FirstName = "Joe", LastName = "Momma", ID = 7 });
            employees.Add(new Employee() { FirstName = "Steve", LastName = "Scott", ID = 8 });
            employees.Add(new Employee() { FirstName = "Lane", LastName = "Roberts", ID = 9 });
            employees.Add(new Employee() { FirstName = "Joe", LastName = "Smarlock", ID = 10 });

            /*            List<Employee> employees1 = new List<Employee>();
                        foreach (Employee employee in employees)
                        {

                            if (employee.FirstName == "Joe")
                            {
                                employees1.Add(employee);
                            }
                        }*/

            List<Employee> employees1 = employees.Where(x => x.FirstName == "Joe").ToList();
            List<Employee> employees2 = employees.Where(x => x.ID > 5).ToList();
            Console.WriteLine(employees);

        }
    }
}
