using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.CommandPattern
{
    public class Stereo
    {
        public string Room { get; private set; }

        public Stereo(string room)
        {
            Room = room;
        }

        public void On()
        {
            Console.WriteLine($"Stereo from {Room} is turning on");
        }
        public void Off()
        {
            Console.WriteLine($"Stereo from {Room} is turning off");
        }
        public void SetCd()
        {
            Console.WriteLine($"Stereo from {Room} is setting CD on");
        }
        public void SetDvd()
        {
            Console.WriteLine($"Stereo from {Room} is setting DVD on");
        }
        public void SetRadio()
        {
            Console.WriteLine($"Stereo from {Room} is setting Radio on");
        }
        public void SetVolume()
        {
            Console.WriteLine($"Stereo from {Room} is setting Volume on");
        }

    }
}
