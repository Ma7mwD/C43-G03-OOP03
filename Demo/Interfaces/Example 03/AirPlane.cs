using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Interfaces.Example_03
{
    internal class AirPlane : Vechile, IMove, IFly
    {

        //Implementation Implicitly
        void IMove.Backward()
        {
            Console.WriteLine("Airplane Move Backward");
        }

        void IMove.Forward()
        {
            Console.WriteLine("Airplane Move Forward");
        }

        void IMove.Left()
        {
            Console.WriteLine("Airplane Move Left");
        }

        void IMove.Right()
        {
            Console.WriteLine("Airplane Move Right");
        }

        //Implenentation Explicitly

        void IFly.Backward()
        {
            Console.WriteLine("Airplane Fly Backward");
        }

        void IFly.Forward()
        {
            Console.WriteLine("Airplane Fly Forward");
        }

        void IFly.Left()
        {
            Console.WriteLine("Airplane Fly Left");
        }

        void IFly.Right()
        {
            Console.WriteLine("Airplane Fly Right");
        }
    }
}
