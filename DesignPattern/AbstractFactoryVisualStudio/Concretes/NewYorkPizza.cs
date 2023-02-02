using DesignPattern.AbstractFactoryVisualStudio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.AbstractFactoryVisualStudio.Concretes
{
    internal class NewYorkPizza : Pizza
    {
        public NewYorkPizza(List<string> ingredients) : base(ingredients)
        {
        }

        public override void Bake()
        {
            Console.WriteLine("Baking new york pizza");
        }

        public override void Box()
        {
            Console.WriteLine("Boxing new york pizza"); ;
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting new york pizza");
        }
    }
}
