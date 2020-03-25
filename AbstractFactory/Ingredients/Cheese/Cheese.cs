using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Ingredients.Cheese
{
    public abstract class Cheese : Ingredient

    {
        protected Cheese(string name) : base(name)
        {
        }
    }
}
