using LogCore.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogCore.Persistence.EntityConfigs
{
    public class ApplicationTypeConfig : IEntityTypeConfiguration<ApplicationType>
    {
        public void Configure(EntityTypeBuilder<ApplicationType> builder)
        {
            builder.HasKey(k => k.Id);

            builder.HasMany(t => t.RequestLogs)
                       .WithOne(t => t.ApplicationType)
                       .HasForeignKey(t => t.ApplicationTypeId);
        }
    }
}
