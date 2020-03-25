using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace SImplePizzaFactory.Pizzas
{
    public abstract class Pizza
    {
        public string Name { get; set; }

        protected Pizza(string name)
        {
            Name = name;
        }

        public abstract void Prepare();
        public abstract void Bake();
        public abstract void Cut();
        public abstract void Box();

        public override string ToString()
        {
            return Name;
        }
    }
}
