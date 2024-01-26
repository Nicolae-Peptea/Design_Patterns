using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.CommandPattern.Receivers
{
    public class Light
    {
        public string Room { get; private set; }

        public Light(string room)
        {
            Room = room;
        }

        public void On()
        {
            Console.WriteLine($"Light from {Room} is on");
        }

        public void Off()
        {
            Console.WriteLine($"Light from {Room} is off");
        }
    }
}
