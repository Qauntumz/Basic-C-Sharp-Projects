using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods_pg_164
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to divide it by two");
            mathop op = new mathop();
            int x = Convert.ToInt32(Console.ReadLine());
            op.MathOperation(x);

            mathop oz = new mathop();
            decimal myNum2 = oz.MathOperation(4, 6);

            Console.WriteLine(myNum2);

            int i;
            int a;
            Addition(out i, out a);

            Console.WriteLine("The values are: {0} {1}", i, a);

            int k = Convert.ToInt32(Console.ReadLine());

            staticlass.multbyfour(k);

            Console.WriteLine(staticlass.multbyfour(k));
            
        }
        public static void Addition(out int i, out int a)
        {
            i = 30;
            a = 40;
        }
    }
}
