﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class CantFly : IFly
    {
        public void Fly()
        {
            Console.WriteLine("не умеет летать");
        }
    }
}
