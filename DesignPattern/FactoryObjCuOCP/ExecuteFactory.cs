using System;
using System.Collections.Generic;

namespace DesignPattern.FactoryObjCuOCP
{
    public class ExecuteFactory
    {
        public void ExecuteCode()
        {
            List<Type> transactions = new List<Type>
            {
                typeof(Deposit),
                typeof(Withdrawal)
            };

            ITransactionFactory factory = new TransactionFactory(transactions);

            ITransaction transaction = factory.CreateTransaction(TransactionType.Deposit);

            if (transaction == null)
            {
                return;
            }

            transaction.Complete();
        }
    }
}
