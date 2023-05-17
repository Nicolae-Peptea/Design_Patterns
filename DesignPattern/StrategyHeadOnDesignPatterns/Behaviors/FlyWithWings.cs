using DesignPattern.StrategyHeadOnDesignPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.StrategyHeadOnDesignPatterns.Behaviors
{
    public class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I fly with wings"); ;
        }
    }
}
