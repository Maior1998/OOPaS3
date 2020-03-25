using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SImplePizzaFactory.Pizzas;
using SImplePizzaFactory.Stores;

namespace SimplePizzaFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            NYPizzaStore store1 = new NYPizzaStore();
            Pizza pizza = store1.OrderPizza("Cheese");
            Console.WriteLine($"{pizza} is ready!\n\n");
            ChicagoPizzaStore store2 = new ChicagoPizzaStore();
            pizza = store2.OrderPizza("Pepperoni");
            Console.WriteLine($"{pizza} is ready!\n\n");
            OrenburgPizzaStore store3 = new OrenburgPizzaStore();
            pizza = store3.OrderPizza("Salted");
            Console.WriteLine($"{pizza} is ready!\n\n");
            Console.WriteLine();
        }
    }
}
