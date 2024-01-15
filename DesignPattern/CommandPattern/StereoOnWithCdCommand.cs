using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.CommandPattern
{
    public class StereoOnWithCdCommand : ICommand
    {
        private readonly Stereo _stereo;

        public StereoOnWithCdCommand(Stereo stereo)
        {
            _stereo = stereo;
        }

        public void Execute()
        {
            _stereo.On();
            _stereo.SetCd();
            _stereo.SetVolume();
        }

        public void Undo()
        {
            throw new NotImplementedException();
        }
    }
}
