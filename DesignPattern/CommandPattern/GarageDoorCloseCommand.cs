using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.CommandPattern
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
            throw new NotImplementedException();
        }
    }
}
