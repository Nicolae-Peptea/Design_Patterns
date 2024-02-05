using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.StatePatternUncleBob.PatternExample
{
    public class Locked : ITurnstileState
    {
        public void Coin(TurnstileFSM turnstileFSM)
        {
            turnstileFSM.TurnstileState = new Unlocked();
        }

        public void Pass(TurnstileFSM turnstileFSM)
        {
        }
    }
}
