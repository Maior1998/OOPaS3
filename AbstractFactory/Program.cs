using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Pizzas;
using AbstractFactory.Stores;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore store = new NyPizzaStore();
            Console.WriteLine($"Store - {store}");
            Pizza pizza = store.OrderPizza("Pepperoni");
            Console.WriteLine($"Ordered - {pizza}");


            Console.WriteLine();
            store = new OrenburgPizzaStore();
            Console.WriteLine($"Store - {store}");
            pizza = store.OrderPizza("Clam");
            Console.WriteLine($"Ordered - {pizza}");


            Console.WriteLine();
            store = new ChicagoPizzaStore();
            Console.WriteLine($"Store - {store}");
            pizza = store.OrderPizza("Veggie");
            Console.WriteLine($"Ordered - {pizza}");
            Console.WriteLine();
        }
    }
}
