using System;
using System.Collections.Generic;

namespace DesignPattern.AbstractFactory
{
    internal class HotDrinkMachine
    {
        private List<Tuple<string, IHotDrinkFactory>> factories = new List<Tuple<string, IHotDrinkFactory>>();

        public HotDrinkMachine()
        {
            foreach (Type t in typeof(HotDrinkMachine).Assembly.GetTypes())
            {
                if (typeof(IHotDrinkFactory).IsAssignableFrom(t) && !t.IsInterface)
                {
                    var factory = Tuple.Create(t.Name.Replace("Factory", string.Empty),
                        (IHotDrinkFactory)Activator.CreateInstance(t));

                    factories.Add(factory);
                }
            }
        }

        public IHotDrink MakeDrink()
        {
            Console.WriteLine("Available Drinks");

            for (int i = 0; i < factories.Count; i++)
            {
                var tuple = factories[i];
                Console.WriteLine($"{i}: {tuple.Item1}");
            }

            while (true)
            {
                string s = Console.ReadLine();

                if (s != null &&
                    int.TryParse(s, out int i) &&
                    i >= 0 &&
                    i < factories.Count)
                {
                    Console.WriteLine("Specify amount");
                    s = Console.ReadLine();

                    if (s != null &&
                        int.TryParse(s, out int amount) &&
                        amount > 0)
                    {
                        return factories[i].Item2.Prepare(amount);
                    }
                }
            }
        }
    }
}
