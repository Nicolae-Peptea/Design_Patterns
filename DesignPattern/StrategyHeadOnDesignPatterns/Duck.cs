using DesignPattern.StrategyHeadOnDesignPatterns.Interfaces;

namespace DesignPattern.StrategyHeadOnDesignPatterns
{
    public abstract class Duck
    {
        protected readonly IFlyBehavior _flyBehavior;
        protected readonly IQuackBehavior _quackBehavior;

        protected Duck(IFlyBehavior flyBehavior, IQuackBehavior quackBehavior)
        {
            _flyBehavior = flyBehavior;
            _quackBehavior = quackBehavior;
        }

        public void PerformFly()
        {
            _flyBehavior.Fly();
        }

        public void PerformQuack()
        {
            _quackBehavior.Quack();
        }

        public abstract void Swim();

        public abstract void Display();
    }
}
