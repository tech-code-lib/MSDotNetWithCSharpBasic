using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysInCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array
            //Can store multiple elements of same type

            int[] numbers = new int[3];
            numbers[0] = 14;
            numbers[1] = 15;
            numbers[2] = 16;

            Console.WriteLine(numbers[2]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[0]);

            string[] names = new string[2];
            names[0] = "John";
            names[1] = "Mike";

            Console.WriteLine(names[0]);

            string[] newNames = { "John", "Mike"};
            Console.WriteLine(newNames[0]);
            Console.WriteLine(newNames[1]);
        }
    }
}
