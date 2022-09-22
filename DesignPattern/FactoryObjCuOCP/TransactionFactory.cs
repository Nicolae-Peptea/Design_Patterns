using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPattern.FactoryObjCuOCP
{
    internal class TransactionFactory : ITransactionFactory
    {

        public List<Type> Transactions { get; private set; }

        public TransactionFactory(List<Type> transactions)
        {
            Transactions = transactions;
        }

        public ITransaction CreateTransaction(TransactionType transactionType)
        {
            Type transactionHandler = Transactions
                .Where(x => x.Name == transactionType.ToString())
                .FirstOrDefault();

            if (transactionHandler == null)
            {
                return null;
            }

            return Activator.CreateInstance(transactionHandler) as ITransaction;
        }
    }
}
