using DesignPattern.StatePatternUncleBob.FiniteStateMachineExample;
using DesignPattern.StatePatternUncleBob.PatternExample.StateMachine;
using DesignPattern.StatePatternUncleBob.PatternExample.States;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.StatePatternUncleBob.PatternExample
{
    public static class ExecuteStatePattern
    {
        public static void Execute()
        {
            Locked lockedState = new Locked();
            Unlocked unlocked = new Unlocked();

            TurnstileFSM turnstileFSM = new SimpleTurnstile();
            turnstileFSM.SetState(lockedState);
            turnstileFSM.Coin();
            turnstileFSM.Coin();
        }
    }
}
