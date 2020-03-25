using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SImplePizzaFactory.Pizzas;
using SImplePizzaFactory.Pizzas.NYStyle;

namespace SImplePizzaFactory.Stores
{
    public class NYPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string pizzatype)
        {
            switch (pizzatype)
            {
                case "Cheese":
                    return new NYStyleCheesePizza();
                case "Clam":
                    return new NYStyleClamPizza();
                case "Pepperoni":
                    return new NYStylePepperoniPizza();
                case "Veggie":
                    return new NYStyleVeggiePizza();
                default:
                    throw new InvalidOperationException("We don't know this type of pizza!");
            }
        }
    }
}
