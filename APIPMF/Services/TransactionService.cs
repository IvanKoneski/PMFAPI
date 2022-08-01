using APIPMF.Database.Repository;
using APIPMF.Models;

namespace APIPMF.Services
{
    public class TransactionService : ITransactonsService
    {
        private readonly ITransactionRepository _transactionRepository;

        public TransactionService(ITransactionRepository transactionRepository)
        {
            _transactionRepository = transactionRepository;
        }

        public Task<Transaction> importTransaction(Transaction  transaction)
        {
            Task<Transaction> transaction2 = _transactionRepository.Create(transaction);
            return transaction2;
        }
    }
}
