using DesignPattern.StrategyHeadOnDesignPatterns.Interfaces;
using System;

namespace DesignPattern.StrategyHeadOnDesignPatterns
{
    public class MallardDuck : Duck
    {
        public MallardDuck(IFlyBehavior flyBehavior, IQuackBehavior quackBehavior)
            : base(flyBehavior, quackBehavior)
        {
        }

        public override void Display()
        {
            Console.WriteLine("I am a Mallard Duck"); ;
        }

        public override void Swim()
        {
            Console.WriteLine("I swim like a Mallard Duck"); ;
        }
    }
}
