using System;

namespace SImplePizzaFactory.Pizzas.OrenburgStyle
{
    public class OrenburgStyleVeggiePizza : Pizza
    {
        public OrenburgStyleVeggiePizza() : base("Orenburg Style Veggie Pizza")
        {
        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing Orenburg Style Veggie Pizza . . .");
        }

        public override void Bake()
        {
            Console.WriteLine("Baking Orenburg Style Veggie Pizza . . .");
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting Orenburg Style Veggie Pizza . . .");
        }

        public override void Box()
        {
            Console.WriteLine("Putting Orenburg Style Veggie Pizza in a box  . . .");
        }
    }
}
