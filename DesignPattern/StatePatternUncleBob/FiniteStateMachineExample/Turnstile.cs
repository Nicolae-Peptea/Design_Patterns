using System;

namespace DesignPattern.StatePatternUncleBob.FiniteStateMachineExample
{
    public class Turnstile
    {
        public void Lock()
        {
            Console.WriteLine("Locking turnstile");
        }

        public void Unlock()
        {
            Console.WriteLine("Unlocking turnstile");
        }

        public void Alarm()
        {
            Console.WriteLine("Alarm Alarm Alarm");
        }

        public void ThankYou()
        {
            Console.WriteLine("Thanks for your kidness");
        }
    }
}