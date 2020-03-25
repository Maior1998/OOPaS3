using System;

namespace SImplePizzaFactory.Pizzas.OrenburgStyle
{
    public class OrenburgStyleClamPizza : Pizza
    {
        public OrenburgStyleClamPizza() : base("Orenburg Style Clam Pizza")
        {
        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing Orenburg Style Clam Pizza . . .");
        }

        public override void Bake()
        {
            Console.WriteLine("Baking Orenburg Style Clam Pizza . . .");
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting Orenburg Style Clam Pizza . . .");
        }

        public override void Box()
        {
            Console.WriteLine("Putting Orenburg Style Clam Pizza in a box  . . .");
        }
    }
}
