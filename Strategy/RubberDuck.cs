﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class RubberDuck : Duck
    {
        public RubberDuck()
           : base(new CantFly(), new CanQuack(), new CanSwim()) { }
    }
}
