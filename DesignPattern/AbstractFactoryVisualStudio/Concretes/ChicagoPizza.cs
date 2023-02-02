using DesignPattern.AbstractFactoryVisualStudio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.AbstractFactoryVisualStudio.Concretes
{
    internal class ChicagoPizza : Pizza
    {
        public ChicagoPizza(List<string> ingredients) : base(ingredients)
        {
        }

        public override void Bake()
        {
            Console.WriteLine("Baking chicago pizza");
        }

        public override void Box()
        {
            Console.WriteLine("Boxing chicago pizza");
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting chicago pizza");
        }
    }
}
