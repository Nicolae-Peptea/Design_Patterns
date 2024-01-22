using DesignPattern.CommandPattern.CommandConcretes;
using DesignPattern.CommandPattern.CommandConcretes.LightCommands;
using DesignPattern.CommandPattern.CommandConcretes.StereoCommands;
using DesignPattern.CommandPattern.CommandConcretes.TvCommands;
using DesignPattern.CommandPattern.CommandInterface;
using DesignPattern.CommandPattern.Invokers;
using DesignPattern.CommandPattern.Receivers;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.CommandPattern.Clients
{
    public static class ExecuteRemoteControlWithMacroCommand
    {
        public static void Execute()
        {
            Light light = new Light("Living Room");
            Tv tv = new Tv("Living Room");
            Stereo stereo = new Stereo("Living Room");

            LightOnCommand lightOnCommand = new LightOnCommand(light);
            StereoOnCommand stereoOnCommand = new StereoOnCommand(stereo);
            TvOnCommand tvOnCommand = new TvOnCommand(tv);

            LightOffCommand lightOffCommand = new LightOffCommand(light);
            StereoOffCommand stereoOffCommand = new StereoOffCommand(stereo);
            TvOffCommand tvOffCommand = new TvOffCommand(tv);

            ICommand[] partyOn = { lightOnCommand , stereoOnCommand, tvOnCommand };
            ICommand[] partyOff = {lightOffCommand , stereoOffCommand,tvOffCommand };

            MacroCommand partyOnMacro = new MacroCommand(partyOn);
            MacroCommand partyOffMacro = new MacroCommand(partyOff);

            SimpleRemoteControl remoteControl = new SimpleRemoteControl();
            remoteControl.SetCommand(0, partyOnMacro, partyOffMacro);

            remoteControl.OnButtonWasPressed(0);
            remoteControl.OffButtonWasPressed(0);

            remoteControl.UndoButtonWasPressed();
        }

    }
}
