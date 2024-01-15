﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.CommandPattern
{
    public class LightOnCommand : ICommand
    {
        private Light _light;

        public LightOnCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
           _light.On();
        }

        public void Undo()
        {
            _light.Off();
        }
    }
}
