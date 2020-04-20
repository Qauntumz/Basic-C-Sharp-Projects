using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods_pg_164
{
    public class mathop
    {
        public void MathOperation(int x)
        {
            Console.WriteLine(x + " Divided by 2 = " + (x / 2));

        }
        public decimal MathOperation(decimal x, decimal y)
        {
            Console.WriteLine("6 * 24 = ");
            int decint = Convert.ToInt32(x * y);
            return decint;
        }
    }
}
