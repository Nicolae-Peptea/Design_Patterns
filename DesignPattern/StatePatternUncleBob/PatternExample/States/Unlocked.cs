using DesignPattern.StatePatternUncleBob.PatternExample.StateMachine;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.StatePatternUncleBob.PatternExample.States
{
    public class Unlocked : SimpleTurnstileState
    {
        public override void Coin(TurnstileFSM turnstileFSM)
        {
            turnstileFSM.Thanks();
        }

        public override void Pass(TurnstileFSM turnstileFSM)
        {
            Locked newState = GetLocked();
            turnstileFSM.SetState(newState);

            turnstileFSM.Lock();
        }
    }
}
