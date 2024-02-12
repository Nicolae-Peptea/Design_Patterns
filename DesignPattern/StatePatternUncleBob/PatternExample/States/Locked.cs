using DesignPattern.StatePatternUncleBob.PatternExample.StateMachine;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.StatePatternUncleBob.PatternExample.States
{
    public class Locked : SimpleTurnstileState
    {
        public override void Coin(TurnstileFSM turnstileFSM)
        {
            Unlocked newState = GetUnlocked();
            turnstileFSM.SetState(newState);

            turnstileFSM.Unlock();
        }

        public override void Pass(TurnstileFSM turnstileFSM)
        {
            turnstileFSM.Alarm();
        }
    }
}
