﻿using System;

namespace DesignPattern.AbstractFactory
{
    internal class CoffeeFactory : IHotDrinkFactory
    {
        public IHotDrink Prepare(int amount)
        {
            Console.WriteLine($"Grind some beans, boil water, pour {amount} ml, add cream and sugar ");
            return new Cofee();
        }
    }
}
