﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Interfaces
{
    internal interface ISeries
    {
        public int Current {  get; set; }
        public void getNext();

        public void reset();
    }
}
