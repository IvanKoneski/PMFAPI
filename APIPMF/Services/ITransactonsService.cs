using APIPMF.Models;

namespace APIPMF.Services
{
    public interface ITransactonsService
    {
        Task<Transaction> importTransaction(Transaction transaction);
    }
}
