using System;
using System.Linq;
using AbstractFactory.Factories;
using AbstractFactory.Ingredients;
using AbstractFactory.Ingredients.Cheese;
using AbstractFactory.Ingredients.Clams;
using AbstractFactory.Ingredients.Dough;
using AbstractFactory.Ingredients.Pepperoni;
using AbstractFactory.Ingredients.Sauce;
using AbstractFactory.Ingredients.Veggies;

namespace AbstractFactory.Pizzas
{
    public abstract class Pizza
    {
        protected readonly PizzaFactory factory;
        public string Name { get; set; }
        protected Dough innerDough;
        protected Sauce innerSauce;
        protected Clams innerClams;
        protected Cheese innerCheese;
        protected Veggie[] innerVeggies;
        protected Pepperoni innerPepperoni;
        
        protected Pizza(PizzaFactory source, string name)
        {
            factory = source;
            Name = name;
        }

        public abstract void Prepare();

        public void Bake()
        {
            Console.WriteLine($"Bake {Name} for 25 minutes at 250");
        }

        public void Cut()
        {
            Console.WriteLine($"Cutting {Name} into slices");
        }

        public void Box()
        {
            Console.WriteLine($"Placing {Name} in box");
        }

        public override string ToString()
        {
            string[] ingridients = new[]
            {
                innerDough?.ToString(),
                innerSauce?.ToString(),
                innerClams?.ToString(),
                innerCheese?.ToString(),
                innerVeggies is null ? null : string.Join<Veggie>(", ",innerVeggies),
                innerPepperoni?.ToString(),
            };
            return $"{Name} with {string.Join(", ",ingridients.Where(elem=>!(elem is null)))}";
        }
    }
}
