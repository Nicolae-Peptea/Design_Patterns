using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.StatePatternUncleBob.PatternExample
{
    public class TurnstileFSM
    {
        public ITurnstileState TurnstileState { get; set; }

        public void Coin()
        {
            TurnstileState.Coin(this);
        }

        public void Pass()
        {

        }

        private void Lock()
        {

        }
        private void Unlock() 
        {

        }

        private void Thanks()
        {

        }

        private void Alarm()
        {

        }
    }
}
