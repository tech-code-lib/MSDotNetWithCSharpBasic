using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArithmeticOperators

            //Adition +
            //SUbtraction -
            //Multiplication *
            //Division /
            //Modulus %

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Enter First Number");
            int first = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second Number");
            int second = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Performing Addition");

            int resultAdd = first + second;

            Console.Write("Addition result: ");
            Console.WriteLine(resultAdd);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("");
            Console.WriteLine("Performing SUbtraction");

            int resultSub = first - second;
            Console.Write("Subtraction result: ");
            Console.WriteLine(resultSub);
            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("Performing Multiplication");

            int resultMult = first * second;
            Console.Write("Multiplication result: ");
            Console.WriteLine(resultMult);

            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Performing Division");

            int resultDiv = first / second;
            Console.Write("Division result: ");
            Console.WriteLine(resultDiv);
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("Performing Modulus");

            int resultRemainder = first % second;
            Console.Write("Remainder: ");
            Console.WriteLine(resultRemainder);

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
