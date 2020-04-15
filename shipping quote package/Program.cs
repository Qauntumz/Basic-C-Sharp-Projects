using System;


namespace shipping_quote_package
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter the package weight.");

            decimal pkgwght = Convert.ToDecimal(Console.ReadLine());
            if (pkgwght > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            else
            {

                Console.WriteLine("Please enter the package width.");
                decimal pkgwidth = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Please enter the package height.");
                decimal pkgheight = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Please enter the package length.");
                decimal pkglength = Convert.ToDecimal(Console.ReadLine());

                if ((pkgwidth + pkgheight + pkglength) > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express. Have a good day.");
                }
                else
                {
                    decimal totalcost = (pkgwidth * pkgheight * pkglength * pkgwght) / 100;
                    Console.WriteLine("Your estimated total for shipping this package is: $" + totalcost +".00");
                }
            }
        }
    }
}
