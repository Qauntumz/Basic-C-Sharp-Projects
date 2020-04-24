using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace const_construc_var_pg_221
{
    class Program
    {
        static void Main(string[] args)
        {
            const string yes = "yes";
            var person = new Person("Josh");
            Console.WriteLine(person.ID);
            Console.WriteLine(yes);
        }
    }
}
