using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AClassInCSharp
{
    public class Cat : IAnimal
    {
        public void Eat()
        {
            Console.WriteLine("Cat Eat Method");
        }

        public void Walk()
        {
            Console.WriteLine("Cat Walk Method");
        }
    }
}
