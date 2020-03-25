using System;

namespace SImplePizzaFactory.Pizzas.NYStyle
{
    public class NYStyleVeggiePizza : Pizza
    {
        public NYStyleVeggiePizza() : base("New York Style Veggie Pizza")
        {
        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing New York Style Veggie Pizza . . .");
        }

        public override void Bake()
        {
            Console.WriteLine("Baking New York Style Veggie Pizza . . .");
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting New York Style Veggie Pizza . . .");
        }

        public override void Box()
        {
            Console.WriteLine("Putting New York Style Veggie Pizza in a box  . . .");
        }
    }
}
