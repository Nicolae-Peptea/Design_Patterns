using DesignPattern.AbstractFactoryVisualStudio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.AbstractFactoryVisualStudio
{
    internal abstract class PizzaStoreWithAbstractFactory
    {
        private readonly IPizzaFactory _factory;

        protected PizzaStoreWithAbstractFactory(IPizzaFactory pizzaFactory)
        {
            _factory = pizzaFactory;
        }

        public IPizza OrderPizza(List<string> ingredients)
        {
            IPizza pizza = _factory.CreatePizza(ingredients);
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }
    }
}
