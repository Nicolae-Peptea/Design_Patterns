using DesignPattern.CommandPattern.CommandInterface;
using DesignPattern.CommandPattern.Receivers;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.CommandPattern.CommandConcretes.TvCommands
{
    public class TvOnCommand : ICommand
    {
        public Tv _tv;

        public TvOnCommand(Tv tv)
        {
            _tv = tv;
        }

        public void Execute()
        {
            _tv.On();
        }

        public void Undo()
        {
            _tv.Off();
        }
    }
}
