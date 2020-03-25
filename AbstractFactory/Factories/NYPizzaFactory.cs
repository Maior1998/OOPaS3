using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Ingredients.Cheese;
using AbstractFactory.Ingredients.Clams;
using AbstractFactory.Ingredients.Dough;
using AbstractFactory.Ingredients.Sauce;

namespace AbstractFactory.Factories
{
    public class NYPizzaFactory :PizzaFactory
    {
        public override Dough createDough()
        {
            return new ThinCrustDough();
        }

        public override Sauce createSauce()
        {
            return new MarinaraSauce();
        }

        public override Cheese createCheese()
        {
            return new ReggianoCheese();
        }

        public override Clams createClamses()
        {
            return new FreshClamses();
        }
    }
}
