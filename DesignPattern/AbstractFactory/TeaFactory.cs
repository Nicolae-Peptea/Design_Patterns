using System;

namespace DesignPattern.AbstractFactory
{
    internal class TeaFactory : IHotDrinkFactory
    {
        public IHotDrink Prepare(int amount)
        {
            Console.WriteLine($"Put in a tea bag, boil water, pour {amount} ml, add lemon, enjou");
            return new Tea();
        }
    }
}
