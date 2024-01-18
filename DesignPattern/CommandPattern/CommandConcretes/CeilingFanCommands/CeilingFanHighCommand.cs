using DesignPattern.CommandPattern.CommandInterface;
using DesignPattern.CommandPattern.Receivers;
using System;

namespace DesignPattern.CommandPattern.CommandConcretes.CeilingFanCommands
{
    public class CeilingFanHighCommand : CeilingFanCommand
    {
        public CeilingFanHighCommand(CeilingFan ceilingFan)
            : base(ceilingFan) { }

        public override void Execute()
        {
            _prevSpeed = _ceilingFan.Speed;
            _ceilingFan.High();
        }
    }
}
