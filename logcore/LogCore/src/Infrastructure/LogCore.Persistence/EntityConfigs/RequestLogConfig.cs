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
    public class RequestLogConfig : IEntityTypeConfiguration<RequestLog>
    {
        public void Configure(EntityTypeBuilder<RequestLog> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(p => p.Action).IsRequired().HasMaxLength(100);
            builder.Property(p => p.Version).IsRequired().HasMaxLength(10);
            builder.Property(p=>p.Controller).IsRequired().HasMaxLength(100);

            builder.HasOne(t => t.ApplicationType)
                .WithMany(t => t.RequestLogs)
                .HasForeignKey(t => t.ApplicationTypeId);
        }
    }
}
