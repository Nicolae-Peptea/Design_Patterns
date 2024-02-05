using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.StatePatternUncleBob.PatternExample
{
    public interface ITurnstileState
    {
        void Coin(TurnstileFSM turnstileFSM);
        void Pass(TurnstileFSM turnstileFSM);
    }
}
