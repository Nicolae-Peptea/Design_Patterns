using System;
using System.Collections.Generic;
using System.Linq;
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
        private List<ICommand> _undoCommands = new List<ICommand>();

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

            _undoCommands.Add(noCommand);
        }

        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            _onCommands[slot] = onCommand;
            _offCommands[slot] = offCommand;
        }

        public void OnButtonWasPressed(int slot)
        {
            ICommand command = _onCommands[slot];
            command.Execute();
            _undoCommands.Add(command);
        }

        public void OffButtonWasPressed(int slot)
        {
            ICommand command = _offCommands[slot];
            command.Execute();
            _undoCommands.Add(command);
        }

        public void UndoButtonWasPressed()
        {
            int undoCommandListLength = _undoCommands.Count - 1;

            if (undoCommandListLength > 0)
            {
                return;
            }

            ICommand undoCommand = _undoCommands.ElementAt(undoCommandListLength);
            undoCommand.Undo();
            _undoCommands.RemoveAt(undoCommandListLength);
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("------ Remote Control ------");

            for (int i = 0; i < _onCommands.Length; i++)
            {
                stringBuilder.AppendLine($"[slot {i}]  {_onCommands[i].GetType().Name}  {_offCommands[i].GetType().Name}");
            }

            for (int i = 0; i < _undoCommands.Count - 1; i++)
            {
                stringBuilder.AppendLine($"[undo command] {_undoCommands[i].GetType().Name}");
            }

            return stringBuilder.ToString();
        }
    }
}
