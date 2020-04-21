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
                int X = Convert.ToInt32(Console.ReadLine());
                int Y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(op.Multiply(X,Y));

                Console.WriteLine("Choose two values to divide the first by the second");
                int G = Convert.ToInt32(Console.ReadLine());
                int H = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(op.Divide(G,H));

                Console.WriteLine("Choose two values to subtract the first by the second");
                int J = Convert.ToInt32(Console.ReadLine());
                int K = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(op.Subtract(J,K));

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
