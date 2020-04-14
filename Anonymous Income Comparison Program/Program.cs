using System;


namespace Anonymous_Income_Comparison_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Person 1:");
            Console.WriteLine("Person 1 Hourly Rate:");
            decimal p1hr = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Person 1 Hours per week:");
            decimal p1hpw = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Person 2:");
            Console.WriteLine("Person 2 Hourly Rate:");
            decimal p2hr = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Person 2 Hours per week:");
            decimal p2hpw = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Person 1 Annual Salary: " + (p1hr * p1hpw)* 52);
            decimal p1total = p1hr * p1hpw;
            Console.WriteLine("Person 2 Annual Salary: " + (p2hr * p2hpw) * 52);
            decimal p2total = p2hr * p2hpw;

            Console.WriteLine("Does Person 1 make more than person 2?");
            Console.WriteLine("Answer is: " + (p1total > p2total));
        }
    }
}
