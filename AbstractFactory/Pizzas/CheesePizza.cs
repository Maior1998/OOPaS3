using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Factories;

namespace AbstractFactory.Pizzas
{
    public class CheesePizza: Pizza

    {
        internal CheesePizza(PizzaFactory source) : base(source, "Cheese Pizza")
        {
        }

        public override void Prepare() 
        {
            innerDough = factory.CreateDough();
            innerCheese = factory.CreateCheese();
            innerSauce = factory.CreateSauce();

        }
    }
}
