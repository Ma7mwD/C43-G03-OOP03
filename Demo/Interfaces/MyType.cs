using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Interfaces
{
    internal class MyType : IMyType /*Implement Interface*/
    {
        private int salary;
        public int Salary 
        { 
            get { return salary; }
            set { salary = value + 10; }
        }

        public void MyFunction()
        {
            Console.WriteLine("Hello Iam My Function");
        }
    }
}
