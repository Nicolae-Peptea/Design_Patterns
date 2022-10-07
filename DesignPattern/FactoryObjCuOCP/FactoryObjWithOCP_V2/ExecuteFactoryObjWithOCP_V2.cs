using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.FactoryObjCuOCP.FactoryObjWithOCP_V2
{
    internal class ExecuteFactoryObjWithOCP_V2
    {
        public void ExecuteCode()
        {
            var factory = new TransactionFactory();

            var instance = factory.CreateInstance(typeof(Entities.Deposit));

            instance.Complete();
        }
        
    }
}
