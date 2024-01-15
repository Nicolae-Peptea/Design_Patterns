using System;
using System.Collections.Generic;
using System.Text;
using DesignPattern.CommandPattern.CommandConcretes;
using DesignPattern.CommandPattern.CommandInterface;

namespace DesignPattern.CommandPattern.Invokers
{
    public class SimpleRemoteControl
    {
        private const int SLOTS = 7;

        private readonly ICommand[] _onCommands;
        private readonly ICommand[] _offCommands;
        private ICommand _undoCommand;

        public SimpleRemoteControl()
        {
            _onCommands = new ICommand[SLOTS];
            _offCommands = new ICommand[SLOTS];

            ICommand noCommand = new NoCommand();
            for (int i = 0; i < SLOTS; i++)
            {
                _onCommands[i] = noCommand;
                _offCommands[i] = noCommand;
            }

            _undoCommand = noCommand;
        }

        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            _onCommands[slot] = onCommand;
            _offCommands[slot] = offCommand;
        }

        public void OnButtonWasPressed(int slot)
        {
            _onCommands[slot].Execute();
            _undoCommand = _onCommands[slot];
        }

        public void OffButtonWasPressed(int slot)
        {
            _offCommands[slot].Execute();
            _undoCommand = _offCommands[slot];
        }

        public void UndoButtonWasPressed()
        {
            _undoCommand.Undo();
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("------ Remote Control ------");

            for (int i = 0; i < _onCommands.Length; i++)
            {
                stringBuilder.AppendLine($"[slot {i}]  {_onCommands[i].GetType().Name}  {_offCommands[i].GetType().Name}");
            }
            stringBuilder.AppendLine($"[undo] {_undoCommand.GetType().Name}");

            return stringBuilder.ToString();
        }
    }
}
