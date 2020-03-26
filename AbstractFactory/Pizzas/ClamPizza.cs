using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Factories;

namespace AbstractFactory.Pizzas
{
    public class ClamPizza : Pizza
    {
        public ClamPizza(PizzaFactory source) : base(source, "Clam Pizza")
        {
        }

        public override void Prepare()
        {
            innerDough = factory.CreateDough();
            innerSauce = factory.CreateSauce();
            innerClams = factory.CreateClamses();
        }
    }
}
