using DesignPattern.FactoryPatternHeadOnDesignPatterns.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.FactoryPatternHeadOnDesignPatterns
{
    internal class ExecuteFactoryPatternHeadOnDesignPatterns
    {
       public void Execute()
        {
            NyPizzaStore nyStylePizzaStore = new NyPizzaStore();
            ChicagoStylePizzaStore chicagoPizzaStore = new ChicagoStylePizzaStore();

            Pizza johnPizza = nyStylePizzaStore.OrderPizza("cheese");
            //Pizza edanPizza = chicagoPizzaStore.OrderPizza("cheese");

        }
    }
}
