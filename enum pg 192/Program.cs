using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enum_pg_192
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter the current day of the week");
                string x = Console.ReadLine();

                int enumVal = Convert.ToInt32((Day)Enum.Parse(typeof(Day), x));
                Console.WriteLine("The valid day of the week entered = " + x);










            }
/*            catch (FormatException)
            {
                Console.WriteLine();
                return;
            }*/
            catch (Exception)
            {
/*                Console.WriteLine(ex.Message);*/
                Console.WriteLine("Please enter the correct name of a day of the week.");
            }
        }
    }
}
