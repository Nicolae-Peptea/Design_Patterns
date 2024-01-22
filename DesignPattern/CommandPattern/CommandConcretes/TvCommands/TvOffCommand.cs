using DesignPattern.CommandPattern.CommandInterface;
using DesignPattern.CommandPattern.Receivers;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.CommandPattern.CommandConcretes.TvCommands
{
    public class TvOffCommand : ICommand
    {
        private readonly Tv _tv;

        public TvOffCommand(Tv tv)
        {
            _tv = tv;
        }

        public void Execute()
        {
            _tv.Off();
        }

        public void Undo()
        {
            _tv.On();
        }
    }
}
