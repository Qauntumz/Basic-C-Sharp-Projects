using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pg_225_exc_handling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("How old are you?");
                int x = Convert.ToInt32(Console.ReadLine());
                if (x <= 0)
                {
                    throw new BelowOrEqualToZeroException();
                }

                DateTime y = DateTime.Now.AddYears(-x);
                Console.WriteLine("You were born in " + y.Year);
                Console.ReadLine();
            }
            catch (BelowOrEqualToZeroException)
            {
                Console.WriteLine("Please enter a number above 0");
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("An error has occured.  Please try again");
                Console.ReadLine();
            }
        }
    }
}
