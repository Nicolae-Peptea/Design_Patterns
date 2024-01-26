using System;
using System.Collections.Generic;
using System.Text;
using DesignPattern.CommandPattern.CommandInterface;

namespace DesignPattern.CommandPattern.CommandConcretes
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
