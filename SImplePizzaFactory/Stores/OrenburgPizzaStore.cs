using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SImplePizzaFactory.Pizzas;
using SImplePizzaFactory.Pizzas.OrenburgStyle;

namespace SImplePizzaFactory.Stores
{
    public class OrenburgPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string pizzatype)
        {
            switch (pizzatype)
            {
                case "Cheese":
                    return new OrenburgStyleCheesePizza();
                case "Clam":
                    return new OrenburgStyleClamPizza();
                case "Pepperoni":
                    return new OrenburgStylePepperoniPizza();
                case "Veggie":
                    return new OrenburgStyleVeggiePizza();
                case "Salted":
                    return new OrenburgStyleSaltedPizza();
                default:
                    throw new InvalidOperationException("We don't know this type of pizza!");
            }
        }
    }
}
