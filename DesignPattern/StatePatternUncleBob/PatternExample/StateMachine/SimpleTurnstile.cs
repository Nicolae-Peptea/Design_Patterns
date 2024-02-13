using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.StatePatternUncleBob.PatternExample.StateMachine
{
    public class SimpleTurnstile : TurnstileFSM
    {
        public override void Alarm()
        {
            Console.WriteLine("Alarm");
        }

        public override void Lock()
        {
            Console.WriteLine("Lock");
        }

        public override void Thanks()
        {
            Console.WriteLine("Thanks");
        }

        public override void Unlock()
        {
            Console.WriteLine("Unlocked");
        }
    }
}
