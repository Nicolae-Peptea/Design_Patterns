using DesignPattern.CommandPattern.Receivers;

namespace DesignPattern.CommandPattern.CommandConcretes.CeilingFanCommands
{
    public class CeilingFanLowCommand : CeilingFanCommand
    {
        public CeilingFanLowCommand(CeilingFan ceilingFan)
            : base(ceilingFan) { }

        public override void Execute()
        {
            _prevSpeed = _ceilingFan.Speed;
            _ceilingFan.Low();
        }
    }
}
