using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_assignment_pg156
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Console.WriteLine("Choose two values to multiply together");

                mathop op = new mathop();

                op.Multiply();

                Console.WriteLine("Choose two values to divide the first by the second");
                op.Divide();

                Console.WriteLine("Choose two values to subtract the first by the second");
                op.Subtract();

            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
