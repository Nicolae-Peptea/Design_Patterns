using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.CommandPattern
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
            throw new NotImplementedException();
        }
    }
}
