using APIPMF.Database.Entities;
using APIPMF.Models;

namespace APIPMF.Database.Repository
{
    public interface ITransactionRepository
    {
        Task<TransactionEntity> GetAll();

        Task<TransactionEntity> Create(TransactionEntity transaction);

    }
}
