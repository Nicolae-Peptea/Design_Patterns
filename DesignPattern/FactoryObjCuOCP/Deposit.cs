using System;

namespace DesignPattern.FactoryObjCuOCP
{
    internal class Deposit : ITransaction
    {
        public void Complete()
        {
            Console.WriteLine("bag deposit");
        }
    }
}
