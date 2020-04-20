using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_pg_176
{
    public class Employee : Person, Iquittable
    {
        public override void sayName(string FirstName, string LastName)
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
        public void Quit()
        {
            Console.WriteLine("I Quit");
        }

    }
}
