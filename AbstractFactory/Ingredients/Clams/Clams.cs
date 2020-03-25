using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Ingredients.Clams
{
    public abstract class Clams : Ingredient 
    {
        protected  Clams(string name) : base(name)
        {
        }
    }
}
