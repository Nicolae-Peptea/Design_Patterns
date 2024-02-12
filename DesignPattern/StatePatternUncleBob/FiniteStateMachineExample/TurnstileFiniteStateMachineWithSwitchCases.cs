using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.StatePatternUncleBob.FiniteStateMachineExample
{
    public abstract class TurnstileFiniteStateMachineWithSwitchCases
    {
        private TurnstileState _state;
        private readonly Turnstile _turnstile;

        public TurnstileFiniteStateMachineWithSwitchCases(Turnstile turnstile)
        {
            _turnstile = turnstile;
        }

        public void Coin() 
        { 
            HandleEvent(TurnstileEvent.COIN);
        }
        public void Pass()
        {
            HandleEvent(TurnstileEvent.PASS); 
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

        protected abstract void ThankYou();
        protected abstract void Unlock();
        protected abstract void Alarm();
        protected abstract void Lock();
    }
}
