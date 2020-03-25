using System;

namespace SImplePizzaFactory.Pizzas.ChicagoStyle
{
    public class ChicagoStyleClamPizza : Pizza
    {
        public ChicagoStyleClamPizza() : base("Chicago Style Clam Pizza")
        {
        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing Chicago Style Clam Pizza . . .");
        }

        public override void Bake()
        {
            Console.WriteLine("Baking Chicago Style Clam Pizza . . .");
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting Chicago Style Clam Pizza . . .");
        }

        public override void Box()
        {
            Console.WriteLine("Putting Chicago Style Clam Pizza in a box  . . .");
        }
    }
}
