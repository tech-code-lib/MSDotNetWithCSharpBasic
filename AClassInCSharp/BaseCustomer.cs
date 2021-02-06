using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AClassInCSharp
{
    public abstract class BaseCustomer
    {
        //private int _age;
        //public int Age
        //{
        //    get
        //    {
        //        return _age;
        //    }
        //    set
        //    {
        //        _age = value;
        //    }
        //}

        public BaseCustomer()
        {
            //this.Age = age;
        }
        public int Age { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        //public virtual int CalculateRewards()
        //{
        //    Random random = new Random();
        //    return random.Next(1000, 10000);
        //}

        public abstract int CalculateRewards();

        public void Shop()
        {
            Console.WriteLine("Shpping....");
        }
    }
}

//ECommerce App
// Two types of Customers - WebCustomer, PremiumCustomer
// CalculateRewards implemented differently in both
// INheritance , BaseCustomer , ChildWebCustomer, ChildPremiumCustomer