using System;


namespace mathproject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number to multiply it by 50");
            decimal xfifty = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Answer is: " + xfifty * 50);

            Console.WriteLine("Input number to add 25 to it");
            decimal plustwofive = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Answer is: " + (plustwofive + 25));

            Console.WriteLine("Input number to Divide it by 12.5");
            int divtwelvefive = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Answer is: " + divtwelvefive / 12.5);

            Console.WriteLine("Input number to check if it is larger than 50");
            decimal grtrthanfifty = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Answer is: " + (grtrthanfifty > 50));

            Console.WriteLine("Input number to check the remainder if divided by 7");
            decimal remainderseven = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Answer is: " + (remainderseven % 7));

        }
    }
}
