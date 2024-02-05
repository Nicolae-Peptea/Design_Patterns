using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.FiniteStateMachine
{
    public class TurnstileFiniteStateMachineWithSwitchCases
    {
        private TurnstileState _state;
        private readonly Turnstile _turnstile;

        public TurnstileFiniteStateMachineWithSwitchCases(Turnstile turnstile)
        {
            _turnstile = turnstile;
        }

        public void HandleEvent(TurnstileEvent turnstileEvent)
        {
            switch (_state)
            {
                case TurnstileState.LOCKED:
                    switch (turnstileEvent)
                    {
                        case TurnstileEvent.COIN:
                            _state = TurnstileState.UNLOCKED;
                            _turnstile.Unlock();
                            break;
                        case TurnstileEvent.PASS:
                            _turnstile.Alarm();
                            break;
                        default:
                            break;
                    }
                    break;
                case TurnstileState.UNLOCKED:
                    switch (turnstileEvent)
                    {
                        case TurnstileEvent.COIN:
                            _turnstile.ThankYou();
                            break;
                        case TurnstileEvent.PASS:
                            _state = TurnstileState.LOCKED;
                            _turnstile.Lock();
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
