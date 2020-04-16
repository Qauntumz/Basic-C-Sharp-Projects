using System;
using System.Collections.Generic;

namespace ArrayandLists
{
    class Program
{
    static void Main()
    {
        Console.WriteLine("Please select an index");
        string[] strArray = {"a", "b", "c", "d", "e"};
        int strinput = Convert.ToInt32(Console.ReadLine());
            if (strinput >= 5)
            {
                Console.WriteLine("That index doesn't exist");
            }
            else
            {
                Console.WriteLine(strArray[strinput]);
            }
            


        Console.WriteLine("Please select an index");
        int[] numArray = {123, 8723, 18273, 1894, 87283 };
        int numinput = Convert.ToInt32(Console.ReadLine());
        
  

            if (numinput >= 5)
            {
                Console.WriteLine("That index doesn't exist");
            }
            else
            {
                Console.WriteLine(numArray[numinput]);
            }

            Console.WriteLine("Please select an index");
            List<string> strList = new List<string>();
            strList.Add("hello");
            strList.Add("my");
            strList.Add("name");
            strList.Add("is");
            strList.Add("josh");
            int strlistinput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(strList[strlistinput]);
        }
}
}
