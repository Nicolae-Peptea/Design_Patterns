using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.StatePatternUncleBob.PatternExample
{
    public class Unlocked : ITurnstileState
    {
        public void Coin(TurnstileFSM turnstileFSM)
        {
            turnstileFSM.TurnstileState = new Locked();
        }

        public void Pass(TurnstileFSM turnstileFSM)
        {
        }
    }
}
