using System;
using System.Text;

namespace concat_toupper_strinbuilder_page131
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "hello ";
            string b = "how ";
            string c = "are you";
            string all = a + b + c;
            Console.WriteLine(all);
            string d = all.ToUpper();
            Console.WriteLine(d);

            StringBuilder sb = new StringBuilder("Hello World!", 25);
            sb.Append(" How are you today?");
            sb.Append(" I hope you are having a wonderful day working on your schoolwork for the tech academy c# course.");
            sb.Append(" Stay safe!!");
            Console.WriteLine(sb);
        }
    }
}
