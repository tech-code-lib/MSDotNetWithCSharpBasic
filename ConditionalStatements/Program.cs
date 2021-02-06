using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your age");
            int age = Convert.ToInt32(Console.ReadLine());

            // <, >, >=, <=, ==, !=
            // a < b

            // LOgical AND &&
            // Logical OR ||
            //if (age > 80 || age < 18)
            //{
            //    Console.WriteLine("You are not eligible");
            //}            
            //else
            //{
            //    Console.WriteLine("You are eligible");
            //}

            //Ternary OPerator

            //(true)?statement1:statement2

            string msg = (age >= 18 && age <= 80) ? 
                "You are eligible" :
                "You are eligible";

            Console.WriteLine(msg);
            Console.WriteLine("Please enter today's day");
            string today = Console.ReadLine();

            
            switch (today)
            {
                case "Sunday":
                    Console.WriteLine("Today is Holiday");
                    break;

                case "Saturday":
                    Console.WriteLine("Today is Half day");
                    break;
                
                default:
                    Console.WriteLine("Today is working day");
                    break;
            }
        }
    }
}
