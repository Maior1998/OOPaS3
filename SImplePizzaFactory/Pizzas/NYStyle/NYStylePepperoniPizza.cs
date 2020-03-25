using System;

namespace SImplePizzaFactory.Pizzas.NYStyle
{
    public class NYStylePepperoniPizza : Pizza
    {
        public NYStylePepperoniPizza() : base("New York Style Pepperoni Pizza")
        {
        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing New York Style Pepperoni Pizza . . .");
        }

        public override void Bake()
        {
            Console.WriteLine("Baking New York Style Pepperoni Pizza . . .");
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting New York Style Pepperoni Pizza . . .");
        }

        public override void Box()
        {
            Console.WriteLine("Putting New York Style Pepperoni Pizza in a box  . . .");
        }
    }
}
