using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.CommandPattern.Receivers
{
    public class CeilingFan
    {
        public const int HIGH = 3;
        public const int MEDIUM = 2;
        public const int LOW = 1;
        public const int OFF = 0;

        private string _location;

        public int Speed { get; private set; }

        public CeilingFan(string location)
        {
            _location = location;
        }

        public void High() 
        {
            Speed = HIGH; 
        }

        public void Medium()
        {
            Speed = MEDIUM;
        }

        public void Low()
        {
            Speed = LOW;
        }

        public void Off() 
        {
            Speed = OFF;
        }


    }
}
