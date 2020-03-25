using System;

namespace SImplePizzaFactory.Pizzas.OrenburgStyle
{
    public class OrenburgStyleCheesePizza : Pizza
    {
        public OrenburgStyleCheesePizza() : base("Orenburg Style Cheese Pizza")
        {
        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing Orenburg Style Cheese Pizza . . .");
        }

        public override void Bake()
        {
            Console.WriteLine("Baking Orenburg Style Cheese Pizza . . .");
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting Orenburg Style Cheese Pizza . . .");
        }

        public override void Box()
        {
            Console.WriteLine("Putting Orenburg Style Cheese Pizza in a box  . . .");
        }

        
    }
}
