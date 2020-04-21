using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods_pg_159
{
    public class mathop
    {
        public int MathOperation(int x)
        {
            return x + 5;
        }

        public int MathOperation(decimal y)
        {
            int decint = Convert.ToInt32(y);
            return decint * 2;
        }
        public int MathOperation(string g)
        {
            int strint = Convert.ToInt32(g);
            return strint - 8;
        }
    }
}