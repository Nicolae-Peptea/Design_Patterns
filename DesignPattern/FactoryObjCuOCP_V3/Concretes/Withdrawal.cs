using DesignPattern.FactoryObjCuOCP_V3.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.FactoryObjCuOCP_V3.Concretes
{
    internal class Withdrawal : ITransaction
    {
        public void Complete()
        {
            Console.WriteLine("Withdrawal");
        }
    }
}
