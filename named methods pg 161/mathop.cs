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
            Console.WriteLine("Weight = " + Weight + " * 2 to get final price");
            Console.WriteLine("final price = " + finalPrice);
        }
    }
}
