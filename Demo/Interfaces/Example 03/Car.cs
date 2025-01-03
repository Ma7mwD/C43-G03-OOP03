using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Interfaces.Example_03
{
    internal class Car : Vechile, IMove
    {
        public void Backward()
        {
            Console.WriteLine("Car Move Backward");
        }

        public void Forward()
        {
            Console.WriteLine("Car Move Forward");
        }

        public void Left()
        {
            Console.WriteLine("Car Move Left");
        }

        public void Right()
        {
            Console.WriteLine("Car Move Right");
        }
    }
}
