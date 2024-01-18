using DesignPattern.CommandPattern.CommandInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.CommandPattern.CommandConcretes
{
    public class MacroCommand : ICommand
    {
        protected ICommand[] _commands;

        public MacroCommand(ICommand[] commands)
        {
            _commands = commands;
        }

        public void Execute()
        {
            for (int i = 0; i < _commands.Length; i++)
            {
                _commands[i].Execute();
            };
        }

        public void Undo()
        {
            throw new NotImplementedException();
        }
    }
}
