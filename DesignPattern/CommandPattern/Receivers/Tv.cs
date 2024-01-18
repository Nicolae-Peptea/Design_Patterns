using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.CommandPattern.Receivers
{
    public class Tv
    {
        public string Room { get; private set; }

        public Tv(string room)
        {
            Room = room;
        }

        public void On()
        {
            Console.WriteLine($"Tv from {Room} is turning on");
        }

        public void Off()
        {
            Console.WriteLine($"Tv from {Room} is turning off");
        }

        public void SetInputChannel()
        {
            Console.WriteLine($"Tv from {Room} is turning setting input channel");
        }

        public void SetVolume()
        {
            Console.WriteLine($"Tv from {Room} is setting up volume");
        }
    }
}
