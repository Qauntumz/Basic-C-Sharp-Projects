using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace named_methods_pg_161
{
    class mathop
    {
        public void MathOperation(int Weight, int finalPrice)
        {
            Console.WriteLine(Weight * 2 + " Multiply this by two to get the final price");
            Console.WriteLine("final price = " + finalPrice);
        }
    }
}
