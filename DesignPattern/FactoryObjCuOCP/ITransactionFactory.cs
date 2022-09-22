namespace DesignPattern.FactoryObjCuOCP
{
    public interface ITransactionFactory
    {
        public ITransaction CreateTransaction(TransactionType transactionType);
    }
}
