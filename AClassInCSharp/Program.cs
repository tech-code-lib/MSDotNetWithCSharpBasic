using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AClassInCSharp
{
    
    class Program
    {
        static void Main(string[] args)
        {
            //CLASS -- START
            //BaseCustomer customer = new BaseCustomer();
            //customer.Name = "John Smith";
            //customer.Email = "john.smith@testemail.com";
            //customer.Age = 25;
            //int rewards = customer.CalculateRewards();
            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.WriteLine($"Customer Name: {customer.Name}, \nEmail: {customer.Email}, \nAge: {customer.Age}, \nTotalRewards: {rewards}");
            //Console.ForegroundColor = ConsoleColor.White;
            //Console.WriteLine();

            //CLASS -- END



            //INHERITANCE -- START

            WebCustomer webCustomer = new WebCustomer();
            webCustomer.Name = "John Smith";
            webCustomer.Email = "john.smith@testemail.com";
            webCustomer.Age = 25;
            int rewardswebCustomer = webCustomer.CalculateRewards();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"WEB - Customer Name: {webCustomer.Name}, \nEmail: {webCustomer.Email}, \nAge: {webCustomer.Age}, \nTotalRewards: {rewardswebCustomer}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

            PremiumCustomer prmCustomer = new PremiumCustomer();
            prmCustomer.Name = "John Smith";
            prmCustomer.Email = "john.smith@testemail.com";
            prmCustomer.Age = 25;
            int rewardsprmCustomer = prmCustomer.CalculateRewards();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Premium - Customer Name: {prmCustomer.Name}, \nEmail: {prmCustomer.Email}, \nAge: {prmCustomer.Age}, \nTotalRewards: {rewardsprmCustomer}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

            //INHERITANCE -- END

            //Polymorphism

            Console.WriteLine("Are you Premium Customer?");
            string response = Console.ReadLine().ToUpper();
            BaseCustomer customer = null;
            string typeOfCustomer = "";
            if (response == "YES")
            {
                customer = new PremiumCustomer();
                typeOfCustomer = "Premium Customer";
            }
            else
            {
                customer = new WebCustomer();
                typeOfCustomer = "Web Customer";
            }

            customer.Name = "John Smith";
            customer.Email = "john.smith@testemail.com";
            customer.Age = 25;
            int rewardscustomer = customer.CalculateRewards();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"POLYMORPHISM {typeOfCustomer}- Customer Name: {customer.Name}, \nEmail: {customer.Email}, \nAge: {customer.Age}, \nTotalRewards: {rewardscustomer}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

            //IAnimal animal = new Dog();
            IAnimal animal = new Cat();
            animal.Eat();
            animal.Walk();
        }
    }
}
