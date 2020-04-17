using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraysandlists_pg_142
{
    class Program
    {
        static void Main(string[] args)
        {

            int p = 1;
            while (p < 10)
            {
                Console.WriteLine(p);
                p++;
            }

            Console.WriteLine("Enter text to add it to array");
            string[] letters = { "a", "b", "c", "d", "e" };
            string X = Console.ReadLine();
            for (int i = 0; i < letters.Length; i++)
            {

                Console.WriteLine(X + letters[i]);
            }

            Console.WriteLine("Enter text to add it to array");
            string[] letters2 = { "f", "g", "h", "i", "j" };
            string Y = Console.ReadLine();
            for (int j = 0; j <= 4; j++)
            {

                Console.WriteLine(Y + letters2[j]);
            }

            Console.WriteLine("Please enter a string value to find the index of list item that match it in the list: Hey Hello my name is josh .");
            List<string> words = new List<string>() { "Hey", "Hello", "my", "name", "is", "josh" };
            string Z = Console.ReadLine();
            int idx = words.FindIndex(word => word.Contains(Z));
            int o = 0;
            foreach (string word in words)
            {
                o++;
                if (word.Contains(Z))
                {
                    Console.WriteLine("The index of " + word + " is " + idx);
                    break;
                }
                else if (words.Count() == o)
                {
                    Console.WriteLine("The search matches none of the list values");
                }
            }

            Console.WriteLine("Please enter a string value to find the index of list item that match it in the list: nice to meet you im josh josh .");
            List<string> wordz = new List<string>() { "nice", "to", "meet", "you", "im", "josh", "josh" };
            string B = Console.ReadLine();
            int k = 0;
            foreach (string worb in wordz)
            {
                k++;
                if (worb.Contains(B))
                {
                    Console.WriteLine("The index of " + worb + " is " + (k - 1));
                }
                
                else if (wordz.Count() == k)
                {
                    if (worb.Contains(B))
                    {
                        Console.WriteLine(" ");
                    }
                    else
                    {
                        Console.WriteLine("The search matches none of the list values");
                    }
                }
            }
            Console.WriteLine("Please enter a string value to find the index of list item that match it in the list: nice to meet you im josh josh .");
            List<string> workz = new List<string>() { "nice", "to", "meet", "you", "im", "josh", "josh" };
            List<string> here = new List<string>();
            int v = 0;
            foreach (string work in workz)
            {
                here.Add(work);
                foreach (string her in here) 
                {
                    if (her == work)
                    {
                        v++;
                    }
                }
                Console.WriteLine("Value = " + work + ", this string has appeared " + v + " times in this list.");
                v=0;
            }
        }
    }
}
