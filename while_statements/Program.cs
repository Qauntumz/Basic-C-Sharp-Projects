using System;

namespace while_statements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your height, you must be atleast 49 to ride.");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter your age");
            int age = Convert.ToInt32(Console.ReadLine());
            while (age < 8)
            {
                bool ofage = (age > 5 && height > 49);
                Console.WriteLine(age);
                Console.WriteLine(ofage);
                age++;
            }

            Console.WriteLine("Please enter your height, you must be atleast 49 to ride.");
            int dheight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter your age");
            int dage = Convert.ToInt32(Console.ReadLine());
            do
            {
                bool dofage = (dage > 5 && dheight > 49);
                Console.WriteLine(dage);
                Console.WriteLine(dofage);
                dage++;
            }
            while (dage < 8);
        }
    }
}
