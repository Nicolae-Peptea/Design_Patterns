using DesignPattern.StatePatternUncleBob.PatternExample.StateMachine;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.StatePatternUncleBob.PatternExample.States
{
    public interface ITurnstileState
    {
        void Coin(TurnstileFSM turnstileFSM);
        void Pass(TurnstileFSM turnstileFSM);
    }
}
