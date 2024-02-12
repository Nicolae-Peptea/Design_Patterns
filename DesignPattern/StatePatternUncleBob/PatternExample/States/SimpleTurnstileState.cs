using DesignPattern.StatePatternUncleBob.PatternExample.StateMachine;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.StatePatternUncleBob.PatternExample.States
{
    public abstract class SimpleTurnstileState : ITurnstileState
    {
        private Locked _lockedState;
        private Unlocked _unlockedState;

        public Locked GetLocked()
        {
            _lockedState ??= new Locked();
            return _lockedState;
        }

        public Unlocked GetUnlocked()
        {
            _unlockedState ??= new Unlocked();
            return _unlockedState;
        }

        public abstract void Coin(TurnstileFSM turnstileFSM);
        public abstract void Pass(TurnstileFSM turnstileFSM);
    }
}
