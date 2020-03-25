using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Ingredients.Sauce
{
    public abstract class Sauce : Ingredient
    {
        protected Sauce(string name) : base(name)
        {
        }
    }
}
