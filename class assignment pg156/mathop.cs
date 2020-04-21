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
        public int Multiply(int X, int Y)
        {
            return X * Y;
           
        }
        public int Divide(int G, int H)
        {
            return G / H;

        }
        public int Subtract(int J, int K)
        {
            return J - K;

        }
        public int Y { get; }
        public int X { get; }
    }
}
