using System;

namespace SImplePizzaFactory.Pizzas.OrenburgStyle
{
    public class OrenburgStylePepperoniPizza : Pizza
    {
        public OrenburgStylePepperoniPizza() : base("Orenburg Style Pepperoni Pizza")
        {
        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing Orenburg Style Pepperoni Pizza . . .");
        }

        public override void Bake()
        {
            Console.WriteLine("Baking Orenburg Style Pepperoni Pizza . . .");
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting Orenburg Style Pepperoni Pizza . . .");
        }

        public override void Box()
        {
            Console.WriteLine("Putting Orenburg Style Pepperoni Pizza in a box  . . .");
        }
    }
}
