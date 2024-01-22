using System;
using System.Collections.Generic;
using System.Text;
using DesignPattern.CommandPattern.CommandInterface;
using DesignPattern.CommandPattern.Receivers;

namespace DesignPattern.CommandPattern.CommandConcretes.GarageCommands
{
    internal class GarageDoorCloseCommand : ICommand
    {
        private readonly GarageDoor _garageDoor;

        public GarageDoorCloseCommand(GarageDoor garageDoor)
        {
            _garageDoor = garageDoor;
        }

        public void Execute()
        {
            _garageDoor.Down();
        }

        public void Undo()
        {
            _garageDoor.Up();
        }
    }
}
