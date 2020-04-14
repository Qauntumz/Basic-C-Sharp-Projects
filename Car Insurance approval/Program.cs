using System;

namespace Car_Insurance_approval
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Have you ever had a DUI?");
            string dui = Console.ReadLine();

            Console.WriteLine("How many speeding tickets do you have?");
            int tickets = Convert.ToInt32(Console.ReadLine());

            bool InsuranceApproved = (age > 15 && dui == "no" && tickets < 3);

            Console.WriteLine("Are you approved for insurance? " + InsuranceApproved);
        }
    }
}
