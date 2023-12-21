using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class CanSwim : ISwim
    {
        public void Swim()
        {
            Console.WriteLine("умеет плавать");
        }
    }
}
