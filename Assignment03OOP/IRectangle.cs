using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03OOP
{
    internal class IRectangle : IShape
    {
        public int Area { get; set; }

        public void DisplayShapeInfo()
        {
            Console.WriteLine("Iam Rectangle");
        }
    }
}
