using APIPMF.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APIPMF.Database
{

    public class TransactionEntityTypeConfiguration : IEntityTypeConfiguration<TransactionEntity>
    {
        public void Configure(EntityTypeBuilder<TransactionEntity> builder)
        {
            builder.ToTable("transaction");
            builder.HasKey(t => t.Id);
            builder.Property(p => p.BeneficiaryName).IsRequired();
            builder.Property(p => p.Date).IsRequired();
            builder.Property(p => p.Direction).IsRequired();
            builder.Property(p => p.Amount).IsRequired();
            builder.Property(p => p.Kind).IsRequired();
            builder.Property(p => p.Catcode);
            builder.Property(p => p.Currency).HasMaxLength(3).IsRequired();
            builder.Property(p => p.Mcc);



        }
    }
}
