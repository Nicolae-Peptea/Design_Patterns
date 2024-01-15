using System;
using System.Collections.Generic;
using System.Text;
using DesignPattern.CommandPattern.CommandInterface;
using DesignPattern.CommandPattern.Receivers;

namespace DesignPattern.CommandPattern.CommandConcretes
{
    public class StereoOffCommand : ICommand
    {
        private readonly Stereo _stereo;

        public StereoOffCommand(Stereo stereo)
        {
            _stereo = stereo;
        }

        public void Execute()
        {
            _stereo.Off();
        }

        public void Undo()
        {
            throw new NotImplementedException();
        }
    }
}
