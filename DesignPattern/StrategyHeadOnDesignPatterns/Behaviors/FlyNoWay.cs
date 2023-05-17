using DesignPattern.StrategyHeadOnDesignPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.StrategyHeadOnDesignPatterns.Behaviors
{
    public class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("No fly boss"); ;
        }
    }
}
