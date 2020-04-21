using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods_pg_160
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                mathop op = new mathop();
                Console.WriteLine("Please enter two values to add them to eachother, or one value to add 2 to it.");
                int x = Convert.ToInt32(Console.ReadLine());


                int y;
                int asdf;
                if(int.TryParse(Console.ReadLine(), out y))
                {
                    asdf = op.MathOperation(x, y);
                }
                else
                {
                    asdf = op.MathOperation(x);
                }
                Console.WriteLine(asdf);

            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (NotFiniteNumberException ex)
            {
                Console.WriteLine(ex.Message);
            }
           catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            
/*            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }*/


        }
    }
}
