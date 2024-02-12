using System;
using System.Collections.Generic;
using System.Text;
using DesignPattern.StatePatternUncleBob.PatternExample.States;

namespace DesignPattern.StatePatternUncleBob.PatternExample.StateMachine
{
    public abstract class TurnstileFSM
    {
        private ITurnstileState _turnstileState;

        public void SetState(ITurnstileState turnstileState)
        {
            _turnstileState = turnstileState;
        }

        public void Coin()
        {
            _turnstileState.Coin(this);
        }

        public void Pass()
        {
            _turnstileState.Pass(this);
        }

        public abstract void Lock();
        public abstract void Unlock();
        public abstract void Thanks();
        public abstract void Alarm();
    }
}
