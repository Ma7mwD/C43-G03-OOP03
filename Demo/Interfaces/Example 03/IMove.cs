using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Interfaces.Example_03
{
    internal interface IMove
    {
        public void Forward();
        public void Backward();
        public void Left();
        public void Right();
    }
}
