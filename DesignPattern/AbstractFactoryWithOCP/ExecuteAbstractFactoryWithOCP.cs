using DesignPattern.AbstractFactoryWithOCP.Concretes;
using DesignPattern.AbstractFactoryWithOCP.Factories;
using DesignPattern.AbstractFactoryWithOCP.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.AbstractFactoryWithOCP
{
    internal class ExecuteAbstractFactoryWithOCP
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

            PaymentServiceProvider transactionsFactory = new PaymentServiceProvider(transactionFactories);

            IFactory<ITransaction> transactionHandler = transactionsFactory.GetHandler(TransactionTypes.Deposit);
            ITransaction transactionObject = transactionHandler.Create();
            transactionObject.Complete();
        }
    }
}
