using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Factories;
using AbstractFactory.Pizzas;

namespace AbstractFactory.Stores
{
    public class NyPizzaStore : PizzaStore
    {
        public NyPizzaStore() : base(new NyPizzaFactory(), "New York Pizza Store")
        {
        }
    }
}
