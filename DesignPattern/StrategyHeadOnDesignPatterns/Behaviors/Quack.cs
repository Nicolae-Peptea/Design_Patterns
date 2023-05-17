using DesignPattern.StrategyHeadOnDesignPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.StrategyHeadOnDesignPatterns.Behaviors
{
    public class Quack : IQuackBehavior
    {
        void IQuackBehavior.Quack()
        {
            Console.WriteLine("I quack"); ;
        }
    }
}
