using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace named_methods_pg_161
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Named parameters");
            mathop op = new mathop();

            op.MathOperation(Weight: 32, finalPrice: 64);

        }
    }
}
