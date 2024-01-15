using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.CommandPattern
{
    public class NoCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("No Command Assigned"); ;
        }

        public void Undo()
        {
            throw new NotImplementedException();
        }
    }
}
