using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods_pg_159
{
    public class mathop
    {
        public int MathOperation(int x, int y)
        {
            return x + y;
        }

        public decimal MathOperation(decimal x, decimal y)
        {
            int decint = Convert.ToInt32(x * y);
            return decint;
        }
        public string MathOperation(string x, string y)
        {
            int g = Convert.ToInt32(x);
            int h = Convert.ToInt32(y);
            return g - h;
        }
    }
}