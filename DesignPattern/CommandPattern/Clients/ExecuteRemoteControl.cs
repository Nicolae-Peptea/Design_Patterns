using System;
using System.Collections.Generic;
using System.Text;
using DesignPattern.CommandPattern.CommandConcretes.GarageCommands;
using DesignPattern.CommandPattern.CommandConcretes.LightCommands;
using DesignPattern.CommandPattern.CommandConcretes.StereoCommands;
using DesignPattern.CommandPattern.Invokers;
using DesignPattern.CommandPattern.Receivers;

namespace DesignPattern.CommandPattern.Clients
{
    public static class ExecuteRemoteControl
    {
        public static void Execute()
        {
            SimpleRemoteControl remoteControl = new SimpleRemoteControl();

            Light livingRoomLight = new Light("Living Room");
            Light kitchenLight = new Light("Kitchen");

            GarageDoor garageDoor = new GarageDoor("Garage");

            Stereo stereo = new Stereo("Living Room");

            LightOnCommand livingRoomLightOn = new LightOnCommand(livingRoomLight);
            LightOffCommand livingRoomLightOff = new LightOffCommand(livingRoomLight);

            LightOnCommand kitchenLightOn = new LightOnCommand(kitchenLight);
            LightOffCommand kitchenLightOff = new LightOffCommand(kitchenLight);

            GarageDoorOpenCommand openGarageDoor = new GarageDoorOpenCommand(garageDoor);
            GarageDoorCloseCommand closeGarageDoor = new GarageDoorCloseCommand(garageDoor);

            StereoOnWithCdCommand stereoOnWithCd = new StereoOnWithCdCommand(stereo);
            StereoOffCommand stereoOff = new StereoOffCommand(stereo);

            remoteControl.SetCommand(0, livingRoomLightOn, livingRoomLightOff);
            remoteControl.SetCommand(1, kitchenLightOn, kitchenLightOff);
            remoteControl.SetCommand(2, openGarageDoor, closeGarageDoor);
            remoteControl.SetCommand(3, stereoOnWithCd, stereoOff);

            Console.WriteLine(remoteControl.ToString());

            remoteControl.OnButtonWasPressed(0);
            remoteControl.OffButtonWasPressed(0);
            remoteControl.OnButtonWasPressed(1);
            remoteControl.OffButtonWasPressed(1);
            remoteControl.OnButtonWasPressed(2);
            remoteControl.OffButtonWasPressed(2);
            remoteControl.OnButtonWasPressed(3);
            remoteControl.OffButtonWasPressed(3);
        }
    }
}
