using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operator_overload_184
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


        public static bool operator ==(Employee employee, Employee nployee)
        {

            return employee.ID == nployee.ID;
        }

        public static bool operator !=(Employee employee, Employee nployee)
        {

            return !(employee.ID == nployee.ID);
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
