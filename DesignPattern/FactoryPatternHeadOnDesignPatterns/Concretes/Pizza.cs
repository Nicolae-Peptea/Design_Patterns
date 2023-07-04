using DesignPattern.FactoryPatternHeadOnDesignPatterns.Abstracts.Ingredients;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.FactoryPatternHeadOnDesignPatterns.Concretes
{
    public abstract class Pizza
    {
        public string Name { get; set; }
        protected Dough Dough { get; set; }
        protected Sauce Sauce { get; set; }
        protected List<Veggie> Veggies { get; set; } =  new List<Veggie>();
        protected Cheese Cheese { get; set; }
        protected Pepperoni Pepperoni { get; set; }
        protected Clams Clam { get; set; }

        public abstract void Prepare();

        public void Bake()
        {
            Console.WriteLine("Bake pizza");
        }

        public void Box()
        {
            Console.WriteLine("Box pizza");
        }

        public void Cut()
        {
            Console.WriteLine("cut pizza");
        }
    }
}
