﻿using System;

namespace DesignPattern.AbstractFactory
{
    internal class Tea : IHotDrink
    {
        public void Consume()
        {
            Console.WriteLine("This tea is nice but i'd prefer it with milk");
        }
    }
}
