using LogCore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogCore.Persistence.EntityConfigs
{
    public class ActionLogConfig : IEntityTypeConfiguration<ActionLog>
    {
        private const int MAX_LENGTH = 100;
        public void Configure(EntityTypeBuilder<ActionLog> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(p => p.ActionName).IsRequired().HasMaxLength(MAX_LENGTH);
            builder.HasOne(t => t.TransactionType)
                  .WithMany(t => t.ActionLogs)
                  .HasForeignKey(p =>p.TransactionTypeId);
        }
    }
}
