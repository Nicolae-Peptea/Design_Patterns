using System;

namespace DesignPattern.FactoryObjCuOCP
{
    internal class Withdrawal : ITransaction
    {
        public void Complete()
        {
            Console.WriteLine("Bag withdrawal");
        }
    }
}
