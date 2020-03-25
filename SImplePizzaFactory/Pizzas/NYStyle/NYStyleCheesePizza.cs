using System;

namespace SImplePizzaFactory.Pizzas.NYStyle
{
    public class NYStyleCheesePizza : Pizza
    {
        public NYStyleCheesePizza() : base("New York Style Cheese Pizza")
        {
        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing New York Style Cheese Pizza . . .");
        }

        public override void Bake()
        {
            Console.WriteLine("Baking New York Style Cheese Pizza . . .");
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting New York Style Cheese Pizza . . .");
        }

        public override void Box()
        {
            Console.WriteLine("Putting New York Style Cheese Pizza in a box  . . .");
        }

        
    }
}
