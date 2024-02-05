using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.StatePatternUncleBob.PatternExample
{
    public static class ExecuteStatePattern
    {
        public static void Execute()
        {
            TurnstileFSM turnstileFSM = new TurnstileFSM();

            turnstileFSM.Coin();

        }
    }
}
