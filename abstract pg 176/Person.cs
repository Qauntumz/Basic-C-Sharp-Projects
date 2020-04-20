using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_pg_176
{
    public abstract class Person
    {
        public abstract void sayName(string FirstName, string LastName);

        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
