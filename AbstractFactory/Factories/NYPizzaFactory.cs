using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Ingredients.Cheese;
using AbstractFactory.Ingredients.Clams;
using AbstractFactory.Ingredients.Dough;
using AbstractFactory.Ingredients.Pepperoni;
using AbstractFactory.Ingredients.Sauce;
using AbstractFactory.Ingredients.Veggies;

namespace AbstractFactory.Factories
{
    public class NyPizzaFactory :PizzaFactory
    {
        public override Dough CreateDough()
        {
            return new ThinCrustDough();
        }

        public override Sauce CreateSauce()
        {
            return new MarinaraSauce();
        }

        public override Cheese CreateCheese()
        {
            return new ReggianoCheese();
        }

        public override Clams CreateClamses()
        {
            return new FreshClamses();
        }

        public override Veggie[] CreateVeggies()
        {
            return new Veggie[] {new Garlic(), new RedPepper(), new Mushroom()};
        }

        public override Pepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }
    }
}
