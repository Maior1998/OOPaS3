using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Ingredients.Pepperoni
{
    public abstract class Pepperoni : Ingredient
    {
        protected Pepperoni(string name) : base(name)
        {
        }
    }
}
