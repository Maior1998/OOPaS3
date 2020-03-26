using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Factories;
using AbstractFactory.Pizzas;

namespace AbstractFactory.Stores
{
    public abstract class PizzaStore
    {
        public string Name { get; private set; }
        protected PizzaFactory innerFactory;

        protected PizzaStore(PizzaFactory factory, string name)
        {
            innerFactory = factory;
            Name = name;
        }

        protected Pizza CreatePizza(string pizzatype)
        {
            switch (pizzatype)
            {
                case "Cheese":
                    return new CheesePizza(innerFactory);
                case "Clam":
                    return new ClamPizza(innerFactory);
                case "Pepperoni":
                    return new PepperoniPizza(innerFactory);
                case "Veggie":
                    return new VeggiePizza(innerFactory);
                default:
                    throw new InvalidOleVariantTypeException("We don't know this type of pizza!");
            }
        }
        public Pizza OrderPizza(string pizzatype)
        {
            Pizza pizza = CreatePizza(pizzatype);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
