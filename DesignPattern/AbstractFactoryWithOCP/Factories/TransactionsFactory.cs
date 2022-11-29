using DesignPattern.AbstractFactoryWithOCP.Concretes;
using DesignPattern.AbstractFactoryWithOCP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.AbstractFactoryWithOCP.Factories
{
    internal class TransactionsFactory
    {
        public List<Tuple<int, IFactory<ITransaction>>> TransactionHandlers { get; private set; }

        public TransactionsFactory(List<Tuple<int, IFactory<ITransaction>>> handlers)
        {            
            TransactionHandlers = handlers;
        }

        public IFactory<ITransaction> GetHandler(TransactionTypes transactionTypes)
        {
            IFactory<ITransaction> handler = TransactionHandlers.Where(x => x.Item1 == (int)transactionTypes)
                .FirstOrDefault().Item2;

            return handler;
        }
    }
}
