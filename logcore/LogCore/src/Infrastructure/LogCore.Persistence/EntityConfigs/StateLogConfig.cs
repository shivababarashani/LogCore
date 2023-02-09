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
    public class StateLogConfig : IEntityTypeConfiguration<StateLog>
    {
        private const int MAX_LENGTH = 100;
        public void Configure(EntityTypeBuilder<StateLog> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(p => p.ActionName).IsRequired().HasMaxLength(MAX_LENGTH);
            builder.Property(p => p.Exception).IsRequired(false);

            builder.HasOne(t => t.LogType)
                 .WithMany(t => t.StateLogs)
                 .HasForeignKey(t => t.LogTypeId);
        }
    }
}
