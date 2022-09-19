using System;
using System.Collections.Generic;
using System.Text;

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
