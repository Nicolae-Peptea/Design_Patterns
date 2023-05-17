using DesignPattern.StrategyHeadOnDesignPatterns.Behaviors;
using DesignPattern.StrategyHeadOnDesignPatterns.Interfaces;

namespace DesignPattern.StrategyHeadOnDesignPatterns
{
    public class StrategyPatternHeadsOnDesignPatternsSimulator
    {
        public void Execute()
        {
            IQuackBehavior quackForMallardDuck = new Quack();
            IFlyBehavior flyBehaviorForMallardDuck = new FlyWithWings();

            Duck mallardDuck = new MallardDuck(flyBehaviorForMallardDuck, quackForMallardDuck);
            mallardDuck.Display();
            mallardDuck.PerformFly();
            mallardDuck.PerformQuack();
            mallardDuck.Swim();

            HunterDevice hunterDevice = new HunterDevice(quackForMallardDuck);
            hunterDevice.Lure();
        }
    }
}
