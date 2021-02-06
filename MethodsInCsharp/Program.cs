using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsInCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Methods
            //Block of code
            int age = 21;
            string name = "John Smith";
            string email = "john.smith@gmail.com";

            PrintData(age, name, email);

            int result = Add(12, 15);
            Console.WriteLine("The result after adding 12 and 15 is " + result);
        }

        static void PrintData(int age, string name)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"The person's age is {age} and name is {name}");
            Console.ForegroundColor = ConsoleColor.White;
        }

        static int PrintData(int age, string name, string email)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"The person's age is {age}, name is {name} and email is {email}");
            Console.ForegroundColor = ConsoleColor.White;
            return 1;
        }
        static int Add(int first, int second)
        {
            int result = first + second;
            return result;

            ///
        }
    }
}
