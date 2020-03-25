using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SImplePizzaFactory.Pizzas.OrenburgStyle
{
    public class OrenburgStyleSaltedPizza : Pizza
    {
        public OrenburgStyleSaltedPizza() : base("Salted Pizza")
        {
        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing Orenburg Style Salted Pizza . . .");
        }

        public override void Bake()
        {
            Console.WriteLine("Baking Orenburg Style Salted Pizza . . .");
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting Orenburg Style Salted Pizza . . .");
        }

        public override void Box()
        {
            Console.WriteLine("Putting Orenburg Style Salted Pizza in a box  . . .");
        }
    }
}
