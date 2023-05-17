using System;
using DesignPattern.StrategyHeadOnDesignPatterns.Interfaces;

namespace DesignPattern.StrategyHeadOnDesignPatterns
{
    public class HunterDevice
    {
        public readonly IQuackBehavior _quackBehavior;

        public HunterDevice(IQuackBehavior quackBehavior)
        {
            _quackBehavior = quackBehavior;
        }

        public void Lure()
        {
            Console.WriteLine("I am a hunter device");
            _quackBehavior.Quack();
        }
    }
}
