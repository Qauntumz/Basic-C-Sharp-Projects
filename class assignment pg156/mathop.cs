using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace class_assignment_pg156
{
    public class mathop
    {
        public void Multiply()
        {
            int X = Convert.ToInt32(Console.ReadLine());
            int Y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(X * Y);
           
        }
        public void Divide()
        {
            int X = Convert.ToInt32(Console.ReadLine());
            int Y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(X / Y);

        }
        public void Subtract()
        {
            int X = Convert.ToInt32(Console.ReadLine());
            int Y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(X - Y);

        }
        public int Y { get; }
        public int X { get; }
    }
}
