using DesignPattern.CommandPattern.CommandInterface;
using DesignPattern.CommandPattern.Receivers;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.CommandPattern.CommandConcretes.CeilingFanCommands
{
    public abstract class CeilingFanCommand : ICommand
    {
        protected CeilingFan _ceilingFan;
        protected int _prevSpeed;

        protected CeilingFanCommand(CeilingFan ceilingFan)
        {
            _ceilingFan = ceilingFan;
        }

        public abstract void Execute();

        public void Undo()
        {
            if (_prevSpeed == CeilingFan.HIGH)
            {
                _ceilingFan.High();
            }
            else if (_prevSpeed == CeilingFan.MEDIUM)
            {
                _ceilingFan.Medium();
            }
            else if (_prevSpeed == CeilingFan.LOW)
            {
                _ceilingFan.Low();
            }
            else if (_prevSpeed == CeilingFan.OFF)
            {
                _ceilingFan.Off();
            }
        }
    }
}
