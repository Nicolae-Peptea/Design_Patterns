using DesignPattern.AbstractFactoryVisualStudio.Concretes;
using DesignPattern.AbstractFactoryVisualStudio.Factories;
using DesignPattern.AbstractFactoryVisualStudio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.AbstractFactoryVisualStudio
{
    internal class NewYorkPizzaStoreWithAbstractFactory : PizzaStoreWithAbstractFactory
    {
        public NewYorkPizzaStoreWithAbstractFactory(IPizzaFactory pizzaFactory) : base(pizzaFactory)
        {
        }

        public NewYorkPizzaStoreWithAbstractFactory(): base(new NewYorkPizzaFactory())
        { 
        }
    }
}
