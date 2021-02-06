using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexType
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "John Smith";
            int age = 25;
            string email = "john.smith@test.com";
            string address = "124 St. New York City, 212121";
            bool ismarried = true;

            Person person;
            person.Name = "Mike";
            person.Age = 21;
            person.Email = "mike@gmail.com";
            person.IsMarried = false;
            person.Address = "2121 xyz";

            Console.WriteLine($"Person Name: {person.Name}, Address: {person.Address}");
            Person person2;
        }
    }

    struct Person
    {
        public string Name;
        public int Age;
        public string Email;
        public string Address;
        public bool IsMarried;
    }
}
