using DesignPattern.FactoryObjCuOCP_V3.Concretes;
using DesignPattern.FactoryObjCuOCP_V3.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.FactoryObjCuOCP_V3.Factories
{
    internal class DepositFactory : IFactory<ITransaction>
    {
        public ITransaction Create()
        {
            return new Deposit();
        }
    }
}
