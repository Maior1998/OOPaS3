using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SImplePizzaFactory.Pizzas;

namespace SImplePizzaFactory
{
    public abstract class PizzaStore
    {
        protected abstract Pizza CreatePizza(string type);
        public Pizza OrderPizza(string type)
        {
            Pizza pizza = CreatePizza(type);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }
    }
}
