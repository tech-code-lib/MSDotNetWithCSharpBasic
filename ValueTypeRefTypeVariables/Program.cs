using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueTypeRefTypeVariables
{    
    class Program
    {
        static void Main(string[] args)
        {
            // variables - ValueType, Reference Type

            //int, bool, long - valueTYpe
            //string - Refence Type

            //Complex Type - Structures - Value Types
            //Complex Type - Class - Reference Types

            int first = 10;
            int second = 15;
            int resultAdd = Add(first, second);

            int resultAddRef = AddRef(ref first, ref second);

            Console.WriteLine(resultAddRef);
            Console.WriteLine(first);
            Console.WriteLine(second);

            int firstOut;
            int secondOut;
            int resultAddOut = AddOut(out firstOut, out secondOut);

            Console.WriteLine(resultAddOut);
            Console.WriteLine(firstOut);
            Console.WriteLine(secondOut);

            Console.WriteLine("Enter your age");
            int age;
            string ageEnteredByUser = Console.ReadLine();
            int.TryParse(ageEnteredByUser, out age);
            Console.WriteLine($"Age: {age}");
        }

        static int Add(int first, int second)
        {
            first = 15;
            second = 15;
            return first + second;
        }

        static int AddRef(ref int first, ref int second)
        {
            first = 25;
            second = 25;
            return first + second;
        }

        static int AddOut(out int first, out int second)
        {
            first = 3;
            second = 4;
            return first + second;
        }


    }
}
