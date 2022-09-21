using System;

namespace DesignPattern.AbstractFactory
{
    internal class Cofee : IHotDrink
    {
        public void Consume()
        {
            Console.WriteLine("This coffee is snesational");
        }
    }
}
