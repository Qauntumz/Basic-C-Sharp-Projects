using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_pg_169
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public void sayName()
        {

            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }



    }
}
