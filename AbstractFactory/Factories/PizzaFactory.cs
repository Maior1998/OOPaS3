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
    public abstract class PizzaFactory
    {
        public abstract Dough createDough();
        public abstract Sauce createSauce();
        public abstract Cheese createCheese();
        public abstract Clams createClamses();
    }
}
