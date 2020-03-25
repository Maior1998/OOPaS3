using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Factories;
using AbstractFactory.Ingredients.Cheese;
using AbstractFactory.Ingredients.Clams;
using AbstractFactory.Ingredients.Dough;
using AbstractFactory.Ingredients.Sauce;

namespace AbstractFactory
{
    public abstract class Pizza
    {
        private readonly PizzaFactory factory;
        public string Name { get; set; }
        private Dough InnerDough;
        private Sauce InnerSauce;
        private Clams InnerClams;
        private Cheese InnerCheese;
        private 

        protected Pizza(PizzaFactory source, string name)
        {
            factory = source;
            Name = name;
        }

        public void Prepare()
        {
            InnerDough = factory.createDough();
            Console.WriteLine($"Added {InnerDough.Name}");
            InnerSauce = factory.createSauce();
            Console.WriteLine($"Added {InnerSauce.Name}");
            InnerClams = factory.createClamses();
            Console.WriteLine($"Added {InnerClams.Name}");
            InnerCheese = factory.createCheese();
            Console.WriteLine($"Added {InnerCheese.Name}");
        }

        public void Bake()
        {
            Console.WriteLine($"");
        }

        public void Cut()
        {

        }

        public void Box()
        {

        }
    }
}
