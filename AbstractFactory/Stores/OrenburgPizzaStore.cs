using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Factories;

namespace AbstractFactory.Stores
{
    public class OrenburgPizzaStore : PizzaStore
    {
        public OrenburgPizzaStore() : base(new OrenburgPizzaFactory(), "Orenburg Pizza Store")
        {
        }
    }
}
