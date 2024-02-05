using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.StatePatternUncleBob.FiniteStateMachineExample
{
    public class Transition
    {
        private TurnstileState _currrentState;
        private TurnstileState _newState;
        private TurnstileEvent _turnstileEvent;
        private Counsumer<Turnstile> _action;
        private Turnstile _turnstile;

        public Transition(TurnstileState currrentState, TurnstileState newState, TurnstileEvent turnstileEvent, Counsumer<Turnstile> action, Turnstile turnstile)
        {
            _currrentState = currrentState;
            _newState = newState;
            _turnstileEvent = turnstileEvent;
            _action = action;
            _turnstile = turnstile;
        }


    }
}
