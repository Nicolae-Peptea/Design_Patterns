using DesignPattern.AbstractFactoryWithOCP.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.AbstractFactoryWithOCP.Concretes
{
    internal class Withdrawal : ITransaction
    {
        public void Complete()
        {
            Console.WriteLine("Withdrawal");
        }
    }
}
