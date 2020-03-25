using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Ingredients.Veggies
{
    public abstract class Veggie: Ingredient
    {
        protected Veggie(string name) : base(name)
        {
        }
    }
}
