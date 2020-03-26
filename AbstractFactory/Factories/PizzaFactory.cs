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
    public abstract class PizzaFactory
    {
        public abstract Dough CreateDough();
        public abstract Sauce CreateSauce();
        public abstract Cheese CreateCheese();
        public abstract Clams CreateClamses();
        public abstract Veggie[] CreateVeggies();
        public abstract Pepperoni CreatePepperoni();
    }
}
