using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RubberDuck rubberDuck = new RubberDuck();
            WildDuck wildDuck = new WildDuck();
            IronDuck ironDuck = new IronDuck();
            PlushDuck plushDuck = new PlushDuck();

            Console.WriteLine("Резиновая уточка");
            rubberDuck.AbilityFly();
            rubberDuck.AbilityQuack();
            rubberDuck.AbilitySwim();

            Console.WriteLine("\nДикая уточка");
            wildDuck.AbilityFly();
            wildDuck.AbilityQuack();
            wildDuck.AbilitySwim();

            Console.WriteLine("\nЖелезная уточка");
            ironDuck.AbilityFly();
            ironDuck.AbilitySwim();
            ironDuck.AbilityQuack();

            Console.WriteLine("\nПлюшевая уточка");
            plushDuck.AbilityFly();
            plushDuck.AbilitySwim();
            plushDuck.AbilityQuack();
        }
    }
}
