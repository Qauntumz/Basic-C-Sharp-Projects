using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods_pg_159
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                mathop op = new mathop();

                int myNum1 = op.MathOperation(8, 5);

                mathop oz = new mathop();
                decimal myNum2 = oz.MathOperation(4, 6);

                mathop ov = new mathop();
                string myNum3 = Convert.ToString(ov.MathOperation(12, 8));
                Console.WriteLine("Int: " + myNum1);
                Console.WriteLine("Decimal to int: " + myNum2);
                Console.WriteLine("string to int: " + myNum3);

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
