using DesignPattern.AbstractFactoryVisualStudio.Factories;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.AbstractFactoryVisualStudio
{
    internal static class ExecuteAbstractFactoryVisualStudio
    {
        public static void Execute()
        {
            List<string> ingredients = new List<string>
            {
                "Mushrooms",
                "Garlic"
            };

            NewYorkPizzaStoreWithAbstractFactory newYorkStore = new NewYorkPizzaStoreWithAbstractFactory();
            newYorkStore.OrderPizza(ingredients);

            ChicagoPizzaFactory chicagoPizzaFactory = new ChicagoPizzaFactory();
            NewYorkPizzaStoreWithAbstractFactory newYorkStoreWithChicagoFlavour = new NewYorkPizzaStoreWithAbstractFactory(chicagoPizzaFactory);
            newYorkStoreWithChicagoFlavour.OrderPizza(ingredients);
        }

    }
}
