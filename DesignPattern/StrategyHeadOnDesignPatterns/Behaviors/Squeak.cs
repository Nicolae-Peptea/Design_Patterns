using DesignPattern.StrategyHeadOnDesignPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.StrategyHeadOnDesignPatterns.Behaviors
{
    public class Squeak : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("I squeak"); ;
        }
    }
}
