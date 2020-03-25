using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SImplePizzaFactory.Pizzas;
using SImplePizzaFactory.Pizzas.ChicagoStyle;

namespace SImplePizzaFactory.Stores
{
    public class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string pizzatype)
        {
            switch (pizzatype)
            {
                case "Cheese":
                    return new ChicagoStyleCheesePizza();
                case "Clam":
                    return new ChicagoStyleClamPizza();
                case "Pepperoni":
                    return new ChicagoStylePepperoniPizza();
                case "Veggie":
                    return new ChicagoStyleVeggiePizza();
                default:
                    throw new InvalidOperationException("We don't know this type of pizza!");
            }
        }
    }
}
