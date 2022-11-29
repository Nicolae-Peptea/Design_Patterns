using DesignPattern.AbstractFactoryWithOCP.Concretes;
using DesignPattern.AbstractFactoryWithOCP.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.AbstractFactoryWithOCP.Factories
{
    internal class DepositFactory : IFactory<ITransaction>
    {
        public ITransaction Create()
        {
            return new Deposit();
        }
    }
}
