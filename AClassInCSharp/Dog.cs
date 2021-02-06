using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AClassInCSharp
{
    public class Dog : IAnimal
    {
        public void Eat()
        {
            Console.WriteLine("Dog Eat Method");
        }

        public void Walk()
        {
            Console.WriteLine("Dog Walk Method");
        }
    }
}
