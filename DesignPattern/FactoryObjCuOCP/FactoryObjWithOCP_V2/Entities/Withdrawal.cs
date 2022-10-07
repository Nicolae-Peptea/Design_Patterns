using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.FactoryObjCuOCP.FactoryObjWithOCP_V2.Entities
{
    internal class Withdrawal : Interfaces.ITransaction
    {
        public void Complete()
        {
            Console.WriteLine("Complete withdrawal");
        }
    }
}
