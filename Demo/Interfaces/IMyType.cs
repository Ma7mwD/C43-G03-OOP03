using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Interfaces
{
    internal interface IMyType
    {
        //default access modifier inside interface is "public"
        //what you can write inside interface
        // 1 - Singnature for property

        public int Salary { get; set; }

        //2 - Singnature for method
        public void MyFunction();

        //3-default implemented method

        public void Print()
        {
            Console.WriteLine("Hello Iam default implemented method In Interface");
        }
    }
}
