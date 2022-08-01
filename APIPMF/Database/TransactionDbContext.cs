using APIPMF.Database.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace APIPMF.Database.Repository
{
    public class TransactionDbContext : DbContext
    {
        public DbSet<TransactionEntity> Transactions { get; set; }

        public TransactionDbContext(DbContextOptions options) : base(options)
        {
        }

        public TransactionDbContext()
        {
        }

        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            AppContext.SetSwitch("Npqsql.EnableLegacyTimestampBehaviour ", true);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
