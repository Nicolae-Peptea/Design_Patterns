using DesignPattern.FactoryObjCuOCP_V3.Concretes;
using DesignPattern.FactoryObjCuOCP_V3.Factories;
using DesignPattern.FactoryObjCuOCP_V3.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.FactoryObjCuOCP_V3
{
    internal class ExecuteFactoryObjCuOCP_V3
    {
        public void Execute()
        {
            IFactory<ITransaction> depositFactory = new DepositFactory();
            IFactory<ITransaction> withdrawalFactory = new WithdrawalFactory();

            var transactionFactories = new List<Tuple<int, IFactory<ITransaction>>>
            {
                Tuple.Create((int)TransactionTypes.Deposit, depositFactory),
                Tuple.Create((int)TransactionTypes.Withdrawal, withdrawalFactory)
            };

            TransactionsFactory transactionsFactory = new TransactionsFactory(transactionFactories);

            var x = transactionsFactory.GetHandler(TransactionTypes.Deposit);
            var transactionObject = x.Create();
            transactionObject.Complete();
        }
    }
}
