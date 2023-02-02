using DesignPattern.AbstractFactoryVisualStudio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.AbstractFactoryVisualStudio.Factories
{
    internal abstract class PizzaFactory : IPizzaFactory
    {
        public abstract IPizza CreatePizza(List<string> ingredients);
    }
}
