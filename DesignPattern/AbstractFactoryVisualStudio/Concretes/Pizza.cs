using DesignPattern.AbstractFactoryVisualStudio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.AbstractFactoryVisualStudio.Concretes
{
    internal abstract class Pizza : IPizza
    {
        public IList<string> Toppings { get; }

        public string Seasonings { get; set; }
        public string SauceType { get; set ; }

        public abstract void Bake();

        public abstract void Box();

        public abstract void Cut();

        protected Pizza(List<string> ingredients)
        {
            Toppings = ingredients;
        }
    }
}
