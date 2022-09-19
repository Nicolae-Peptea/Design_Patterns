using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.AbstractFactory
{
    internal class HotDrinkMachine
    {
        public enum AvailableDrink
        {
            Coffee,
            Tea,
        }

        private Dictionary<AvailableDrink, IHotDrinkFactory> factories =
            new Dictionary<AvailableDrink, IHotDrinkFactory>();

        public HotDrinkMachine()
        {
            foreach (AvailableDrink drink in Enum.GetValues(typeof(AvailableDrink)))
            {
                var drinkFactoryName = "DesignPattern.AbstractFactory." + Enum.GetName(typeof(AvailableDrink), drink) + "Factory";
                var factory = (IHotDrinkFactory)Activator.CreateInstance(Type.GetType(drinkFactoryName));

                factories.Add(drink, factory);
            }
        }

        public IHotDrink MakeDrink(AvailableDrink drink, int amount)
        {
            return factories[drink].Prepare(amount);
        }
    }
}
