using System;
using System.Collections.Generic;
using System.Text;
using DesignPattern.CommandPattern.CommandInterface;
using DesignPattern.CommandPattern.Receivers;

namespace DesignPattern.CommandPattern.CommandConcretes
{
    public class LightOffCommand : ICommand
    {
        private readonly Light _light;

        public LightOffCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.Off();
        }

        public void Undo()
        {
            _light.On();
        }
    }
}
