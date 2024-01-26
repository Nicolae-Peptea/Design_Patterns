using DesignPattern.CommandPattern.CommandInterface;
using DesignPattern.CommandPattern.Receivers;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.CommandPattern.CommandConcretes.StereoCommands
{
    public class StereoOnCommand : ICommand
    {
        private readonly Stereo _stereo;

        public StereoOnCommand(Stereo stereo)
        {
            _stereo = stereo;
        }

        public void Execute()
        {
            _stereo.On();
        }

        public void Undo()
        {
            _stereo.Off();
        }
    }
}
