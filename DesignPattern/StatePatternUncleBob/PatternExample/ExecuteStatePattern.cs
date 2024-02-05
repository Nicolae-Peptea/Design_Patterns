using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.StatePatternUncleBob.PatternExample
{
    public static class ExecuteStatePattern
    {
        public static void Execute()
        {
            Locked locked = new Locked();
            Unlocked unlocked = new Unlocked();

            TurnstileFSM turnstileFSM = new TurnstileFSM();
            turnstileFSM.TurnstileState = locked;

            turnstileFSM.Coin();

        }
    }
}
