using APIPMF.Database.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace APIPMF.Database.Repository
{
    public class TransactionDbContext : DbContext
    {
        public TransactionDbContext(DbContextOptions options) : base(options)
        {
        }

        protected TransactionDbContext()
        {
        }

        public DbSet<TransactionEntity> Transactions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
