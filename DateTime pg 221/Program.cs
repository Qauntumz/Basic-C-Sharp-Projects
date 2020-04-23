using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DateTime_pg_221
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("Please enter a number");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("in " + x + " hours it will be " + (DateTime.Now.AddHours(x)));
        }
    }
}
