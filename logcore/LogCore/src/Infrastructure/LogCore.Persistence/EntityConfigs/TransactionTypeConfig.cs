using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using LogCore.Domain.Entities;

namespace LogCore.Persistence.EntityConfigs
{
    public class TransactionTypeConfig : IEntityTypeConfiguration<TransactionType>
    {
        public void Configure(EntityTypeBuilder<TransactionType> builder)
        {
            builder.HasKey(k => k.Id);

            builder.HasOne(t => t.ProxyCompany)
                       .WithMany(t => t.TransactionTypes)
                       .HasForeignKey(t => t.ProxyCompanyId);

            builder.HasMany(t => t.ActionLogs)
                  .WithOne(t => t.TransactionType)
                  .HasForeignKey(p => p.TransactionTypeId);
        }
    }
}
