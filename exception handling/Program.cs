using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exception_handling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a number to divide numers 2, 4, 8, and 64 by that number.");
                List<int> nums = new List<int>() { 2, 4, 8, 64 };
                int z = Convert.ToInt32(Console.ReadLine());
                foreach(int num in nums)
                {
                    Console.WriteLine(num / z);
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
            Console.WriteLine("Try and catch block passed");
        }
    }
}
