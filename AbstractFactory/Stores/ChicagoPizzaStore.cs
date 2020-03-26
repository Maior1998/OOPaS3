using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Factories;

namespace AbstractFactory.Stores
{
    public class ChicagoPizzaStore : PizzaStore
    {
        public ChicagoPizzaStore() : base(new ChicagoPizzaFactory(), "Chicago Pizza Store")
        {
        }
    }
}
