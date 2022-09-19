﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.AbstractFactory
{
    internal class ExecuteAbstractFactory
    {
        public void Execute()
        {
            var machine = new HotDrinkMachine();
            var drink = machine.MakeDrink();
            drink.Consume();
        }
    }
}
