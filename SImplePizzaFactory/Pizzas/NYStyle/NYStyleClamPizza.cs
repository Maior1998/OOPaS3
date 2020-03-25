using System;

namespace SImplePizzaFactory.Pizzas.NYStyle
{
    public class NYStyleClamPizza : Pizza
    {
        public NYStyleClamPizza() : base("New York Style Clam Pizza")
        {
        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing New York Style Clam Pizza . . .");
        }

        public override void Bake()
        {
            Console.WriteLine("Baking New York Style Clam Pizza . . .");
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting New York Style Clam Pizza . . .");
        }

        public override void Box()
        {
            Console.WriteLine("Putting New York Style Clam Pizza in a box  . . .");
        }
    }
}
