using APIPMF.Database.Entities;

namespace APIPMF.Database.Repository
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly TransactionDbContext _dbContext;

        public TransactionRepository(TransactionDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<TransactionEntity> Create(TransactionEntity transaction)
        {
            _dbContext.Add(transaction);

            await _dbContext.SaveChangesAsync();

            return transaction;
        }

        public Task<TransactionEntity> GetAll()
        {
            throw new NotImplementedException();
        }

    }
}
