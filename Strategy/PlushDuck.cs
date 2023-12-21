﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class PlushDuck : Duck
    {
        public PlushDuck()
           : base(new CantFly(), new CanQuack(), new CantSwim()) { }
    }
}
