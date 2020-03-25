using System;

namespace SImplePizzaFactory.Pizzas.ChicagoStyle
{
    public class ChicagoStyleCheesePizza : Pizza
    {
        public ChicagoStyleCheesePizza() : base("Chicago Style Cheese Pizza")
        {
        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing Chicago Style Cheese Pizza . . .");
        }

        public override void Bake()
        {
            Console.WriteLine("Baking Chicago Style Cheese Pizza . . .");
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting Chicago Style Cheese Pizza . . .");
        }

        public override void Box()
        {
            Console.WriteLine("Putting Chicago Style Cheese Pizza in a box  . . .");
        }

        
    }
}
