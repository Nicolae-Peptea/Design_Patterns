using DesignPattern.FactoryObjCuOCP.FactoryObjWithOCP_V2.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.FactoryObjCuOCP.FactoryObjWithOCP_V2
{
    internal class TransactionFactory : IFactory<Interfaces.ITransaction>
    {
        public Interfaces.ITransaction CreateInstance(Type instanceType)
        {
            if (!IsValid(instanceType))
            {
                return null;
            }

            var test = Activator.CreateInstance(instanceType);
            return Activator.CreateInstance(instanceType) as Interfaces.ITransaction;
        }

        private bool IsValid(Type instanceType)
        {
            return typeof(Interfaces.ITransaction).IsAssignableFrom(instanceType) && instanceType.IsInterface;
        }
    }
}
