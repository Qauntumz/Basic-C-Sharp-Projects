using System;

namespace tech_academy_daily_report
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");

            Console.WriteLine("What course are you on?");

            string courseName = Console.ReadLine();

            Console.WriteLine("What page number?");
            int page = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Do you need help with anything? Please answer “true” or “false”");
            bool help = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string positiveFeedback = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string anyFeedback = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            int hourstoday = Convert.ToInt32(Console.ReadLine());
        }
    }
}
