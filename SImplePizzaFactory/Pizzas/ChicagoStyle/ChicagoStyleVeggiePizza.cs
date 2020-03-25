using System;

namespace SImplePizzaFactory.Pizzas.ChicagoStyle
{
    public class ChicagoStyleVeggiePizza : Pizza
    {
        public ChicagoStyleVeggiePizza() : base("Chicago Style Veggie Pizza")
        {
        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing Chicago Style Veggie Pizza . . .");
        }

        public override void Bake()
        {
            Console.WriteLine("Baking Chicago Style Veggie Pizza . . .");
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting Chicago Style Veggie Pizza . . .");
        }

        public override void Box()
        {
            Console.WriteLine("Putting Chicago Style Veggie Pizza in a box  . . .");
        }
    }
}
