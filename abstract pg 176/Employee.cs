using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_pg_176
{
    public class Employee : Person, Iquittable
    {
        public override void sayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
        public void Quit()
        {
            Console.WriteLine("I Quit");
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override int GetHashCode()
        {
            return ID;
        }

        public int ID { get; set; }

        public override bool Equals(object obj)
        {
            Employee nployee = obj as Employee;
            if (object.ReferenceEquals(null, nployee)) return false;
            return ID == nployee.ID;
        }

        public static bool operator ==(Employee employee, Employee nployee)
        {
            if (object.ReferenceEquals(null, employee))
                return object.ReferenceEquals(null, nployee);
            else if (object.ReferenceEquals(null, nployee))
                return false;
            return employee.Equals(nployee);
        }

        public static bool operator !=(Employee employee, Employee nployee)
        {
            if (object.ReferenceEquals(null, employee))
                return !object.ReferenceEquals(null, nployee);
            else if (object.ReferenceEquals(null, nployee))
                return true;
            return !employee.Equals(nployee);
        }











        /*       public static bool operator== (Employee employee, Employee nployee)
               {
                   if (employee.ID == nployee.ID)
                   {
                       return true;
                   }

               }
               public static bool operator !=(Employee employee, Employee nployee)
               {
                   if (employee.ID != nployee.ID)
                   {
                       return employee != nployee;
                   }

               }*/
    }
}
