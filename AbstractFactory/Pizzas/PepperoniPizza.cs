using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Factories;

namespace AbstractFactory.Pizzas
{
    public class PepperoniPizza : Pizza
    {
        public PepperoniPizza(PizzaFactory source) : base(source, "Pepperoni Pizza")
        {
        }

        public override void Prepare()
        {
            innerDough = factory.CreateDough();
            innerSauce = factory.CreateSauce();
            innerPepperoni = factory.CreatePepperoni();
        }
    }
}
