using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace file_io_pg_218
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            using (StreamWriter file = new StreamWriter(@"C:\Users\purej\Desktop\log2.txt", true))
            {
                file.WriteLine(x);
            }
            string y = File.ReadAllText(@"C:\Users\purej\Desktop\log2.txt");
            Console.WriteLine(y);
        }
    }
}
