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

            Console.WriteLine("Please enter twp values to add them to eachother, or one value to add 2 to it.");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            mathop op = new mathop();

            Console.WriteLine(op.MathOperation(x, y));

            
        }
    }
}
