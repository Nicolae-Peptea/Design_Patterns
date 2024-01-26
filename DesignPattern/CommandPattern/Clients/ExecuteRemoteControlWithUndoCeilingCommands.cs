using DesignPattern.CommandPattern.CommandConcretes.CeilingFanCommands;
using DesignPattern.CommandPattern.Invokers;
using DesignPattern.CommandPattern.Receivers;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.CommandPattern.Clients
{
    public static class ExecuteRemoteControlWithUndoCeilingCommands
    {
        public static void Execute()
        {
            SimpleRemoteControl remoteControl = new SimpleRemoteControl();

            CeilingFan ceilingFan = new CeilingFan("Living Room");

            CeilingFanLowCommand ceilingFanLowCommand = new CeilingFanLowCommand(ceilingFan);
            CeilingFanMediumCommand ceilingFanMediumCommand  = new CeilingFanMediumCommand(ceilingFan);
            CeilingFanHighCommand ceilingFanHighCommand = new CeilingFanHighCommand(ceilingFan);
            CeilingFanOffCommand ceilingFanOffCommand = new CeilingFanOffCommand(ceilingFan);

            remoteControl.SetCommand(0, ceilingFanMediumCommand, ceilingFanOffCommand);
            remoteControl.SetCommand(1, ceilingFanHighCommand, ceilingFanOffCommand);

            remoteControl.OnButtonWasPressed(0);
            remoteControl.OffButtonWasPressed(0);
            Console.WriteLine(remoteControl.ToString());
            remoteControl.UndoButtonWasPressed();
          
            remoteControl.OnButtonWasPressed(1);
            Console.WriteLine(remoteControl.ToString());
            remoteControl.UndoButtonWasPressed();
            remoteControl.OffButtonWasPressed(1);
            remoteControl.OffButtonWasPressed(1);
            remoteControl.UndoButtonWasPressed();

        }
    }
}
