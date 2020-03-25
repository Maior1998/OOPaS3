using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Ingredients
{
    public abstract class Ingredient
    {
        public string Name { get; set; }

        protected Ingredient(string name)
        {
            Name = name;
        }
    }
}
