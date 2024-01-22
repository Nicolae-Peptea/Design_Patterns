using System;
using System.Collections.Generic;
using System.Text;
using DesignPattern.CommandPattern.CommandInterface;
using DesignPattern.CommandPattern.Receivers;

namespace DesignPattern.CommandPattern.CommandConcretes.GarageCommands
{
    internal class GarageDoorOpenCommand : ICommand
    {
        private readonly GarageDoor _garageDoor;

        public GarageDoorOpenCommand(GarageDoor garageDoor)
        {
            _garageDoor = garageDoor;
        }

        public void Execute()
        {
            _garageDoor.Up();
        }

        public void Undo()
        {
            _garageDoor.Down();
        }
    }
}
