using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Factories;
using AbstractFactory.Ingredients.Dough;

namespace AbstractFactory.Pizzas
{
    public class VeggiePizza : Pizza
    {
        public VeggiePizza(PizzaFactory source) : base(source, "Veggie Pizza")
        {
        }

        public override void Prepare()
        {
            innerDough = factory.CreateDough();
            innerSauce = factory.CreateSauce();
            innerVeggies = factory.CreateVeggies();
        }
    }
}
