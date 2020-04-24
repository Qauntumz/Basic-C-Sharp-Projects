using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace const_construc_var_pg_221
{
    class Person
    {
        public Person(string name) : this(name, 1)
        {
        }
        public Person(string name, int id)
        {
            Name = name;
            ID = id;
        }


        public string Name { get; set; }
        public int ID { get; set; }
    }
}
