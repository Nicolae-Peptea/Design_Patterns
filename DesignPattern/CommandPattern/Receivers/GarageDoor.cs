using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.CommandPattern.Receivers
{
    public class GarageDoor
    {
        public string Room { get; private set; }

        public GarageDoor(string room)
        {
            Room = room;
        }

        public void Up()
        {
            Console.WriteLine("Garage Door is Open");
        }
        public void Down()
        {
            Console.WriteLine("Garage Door is Closing");
        }
        public void Stop()
        {

        }
        public void LightOn()
        {

        }

        public void LightOff()
        {

        }
    }
}
