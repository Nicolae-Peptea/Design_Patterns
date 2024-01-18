using DesignPattern.CommandPattern.CommandInterface;
using DesignPattern.CommandPattern.Receivers;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.CommandPattern.CommandConcretes.CeilingFanCommands
{
    public class CeilingFanOffCommand : CeilingFanCommand
    {
        public CeilingFanOffCommand(CeilingFan ceilingFan)
            : base(ceilingFan) { }

        public override void Execute()
        {
            _prevSpeed = _ceilingFan.Speed;
            _ceilingFan.Off(); ;
        }
    }
}
