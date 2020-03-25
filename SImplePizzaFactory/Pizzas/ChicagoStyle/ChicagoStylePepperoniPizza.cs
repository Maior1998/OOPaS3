using System;

namespace SImplePizzaFactory.Pizzas.ChicagoStyle
{
    public class ChicagoStylePepperoniPizza : Pizza
    {
        public ChicagoStylePepperoniPizza() : base("Chicago Style Pepperoni Pizza")
        {
        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing Chicago Style Pepperoni Pizza . . .");
        }

        public override void Bake()
        {
            Console.WriteLine("Baking Chicago Style Pepperoni Pizza . . .");
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting Chicago Style Pepperoni Pizza . . .");
        }

        public override void Box()
        {
            Console.WriteLine("Putting Chicago Style Pepperoni Pizza in a box  . . .");
        }
    }
}
