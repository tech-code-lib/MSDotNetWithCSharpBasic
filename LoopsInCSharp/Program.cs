using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // For Loop 

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"The value of i is {i}");
            }

            Console.WriteLine("");
            for (int i = 5; i > 0; i--)
            {
                Console.WriteLine($"The value of i is {i}");
            }

            //For each
            string[] names = { "John", "Mike", "David" };

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            foreach (string item in names)
            {
                Console.WriteLine(item);
            }

            // While Loop

            int n = 0;
            while (n < 5)
            {
                Console.WriteLine($"The value of i is {n} in while loop.");
                //n = n + 1;
                n++;
            }
            int m = 0;
            do
            {
                Console.WriteLine("This line will execute defintely.");
                m++;
            } while (m < 5);
            //Break, Continue

            Console.WriteLine("Break and Contiue example.");
            Console.WriteLine("");
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    break;
                }
                Console.WriteLine($"Break example: The value of i is {i}");
            }
            Console.WriteLine("This statement is after break.");

            Console.ForegroundColor = ConsoleColor.Yellow;
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    continue;
                }
                Console.WriteLine($"Continue example: The value of i is {i}");
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
