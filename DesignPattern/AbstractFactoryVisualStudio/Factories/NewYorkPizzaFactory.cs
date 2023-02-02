using DesignPattern.AbstractFactoryVisualStudio.Concretes;
using DesignPattern.AbstractFactoryVisualStudio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.AbstractFactoryVisualStudio.Factories
{
    internal class NewYorkPizzaFactory : PizzaFactory
    {
        public override IPizza CreatePizza(List<string> ingredients)
        {
            return new NewYorkPizza(ingredients);
        }
    }
}
