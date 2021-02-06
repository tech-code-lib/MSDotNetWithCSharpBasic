using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypesAndVariablesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //type variableName = value;
            string name = "John";

            //Console.WriteLine(name);

            int number = 15;
            double decimalNumber = 15.25;
            bool isTRue = true; //false

            Console.WriteLine("Please enter your name");
            string userEnteredName = Console.ReadLine();
            Console.WriteLine(userEnteredName);

            Console.WriteLine("Please enter your age");
            string userEnteredAge = Console.ReadLine();
            int age = Convert.ToInt32(userEnteredAge);

            Console.WriteLine(age);
        }
    }
}
