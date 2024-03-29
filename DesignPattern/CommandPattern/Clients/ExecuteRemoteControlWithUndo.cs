﻿using System;
using System.Collections.Generic;
using System.Text;
using DesignPattern.CommandPattern.CommandConcretes.LightCommands;
using DesignPattern.CommandPattern.Invokers;
using DesignPattern.CommandPattern.Receivers;

namespace DesignPattern.CommandPattern.Clients
{
    public static class ExecuteRemoteControlWithUndo
    {
        public static void Execute()
        {
            SimpleRemoteControl remoteControl = new SimpleRemoteControl();

            Light livingRoomLight = new Light("Living Room");

            LightOnCommand livingRoomLightOn = new LightOnCommand(livingRoomLight);
            LightOffCommand livingRoomLightOff = new LightOffCommand(livingRoomLight);

            remoteControl.SetCommand(0, livingRoomLightOn, livingRoomLightOff);
            remoteControl.OnButtonWasPressed(0);
            remoteControl.OffButtonWasPressed(0);

            Console.WriteLine(remoteControl.ToString());

            remoteControl.UndoButtonWasPressed();

            remoteControl.OffButtonWasPressed(0);
            remoteControl.OnButtonWasPressed(0);

            Console.WriteLine(remoteControl.ToString());

            remoteControl.UndoButtonWasPressed();
        }
    }
}
