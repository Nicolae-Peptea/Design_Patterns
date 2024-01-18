using DesignPattern.CommandPattern.Receivers;

namespace DesignPattern.CommandPattern.CommandConcretes.CeilingFanCommands
{
    public class CeilingFanMediumCommand : CeilingFanCommand
    {
        public CeilingFanMediumCommand(CeilingFan ceilingFan)
            : base(ceilingFan) { }

        public override void Execute()
        {
            _prevSpeed = _ceilingFan.Speed;
            _ceilingFan.Medium();
        }
    }
}
