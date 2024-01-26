﻿using DesignPattern.CommandPattern.CommandInterface;
using System;
using System.Collections.Generic;
using System.Linq;
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
            for (int i = _commands.Length - 1; i >= 0; i--)
            {
                _commands[i].Undo();
            }
        }
    }
}
