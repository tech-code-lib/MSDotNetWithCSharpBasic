using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsInCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Collections
            //Arrays - 

            Customer customer1 = new Customer() { Name = "John", Email = "john@test.com" };
            Customer customer2 = new Customer() { Name = "Mike", Email = "Mike@test.com" };
            Customer customer3 = new Customer() { Name = "Tom", Email = "tom@test.com" };

            Customer[] customerArray = new Customer[3] { customer1, customer2, customer3 };
            // Limitation of length, Cannot add more customers

            Console.WriteLine("--------Arrays-----------");
            foreach (var item in customerArray)
            {
                Console.WriteLine($"Name: {item.Name}, Email: {item.Email}");
            }

            Console.WriteLine("--------ArrayList-----------");
            //Namespace - System.Collections
            //Add any object

            ArrayList arrayList = new ArrayList();
            arrayList.Add(customer1);
            arrayList.Add(customer2);
            //arrayList.Add("Test");//This will fail as String can not be converted to Customer

            foreach (var item in arrayList)
            {
                //Since each item is added as Object in ArrayList, you have to conver it to use it.
                Customer customer = (Customer)item;//Cast item to Customer
                Console.WriteLine($"Name: {customer.Name}, Email: {customer.Email}");
            }

            Console.WriteLine("--------List-----------");
            //Generic List
            //Create List for any type
            // e.g. List<string> => this is List for strings only
            // e.g. List<int> => this is List for int only
            // e.g. List<Customer> => this is List for Customers only

            List<Customer> customers = new List<Customer>();
            customers.Add(customer1);
            customers.Add(customer2);
            customers.Add(customer3);

            foreach (var customer in customers)
            {
                //No need to convert it now
                Console.WriteLine($"Name: {customer.Name}, Email: {customer.Email}");
            }           
        }
    }
}

