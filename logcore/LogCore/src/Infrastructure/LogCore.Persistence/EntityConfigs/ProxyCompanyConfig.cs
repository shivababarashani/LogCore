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
    public class ProxyCompanyConfig : IEntityTypeConfiguration<ProxyCompany>
    {
        public void Configure(EntityTypeBuilder<ProxyCompany> builder)
        {
            builder.HasKey(k => k.Id);

            builder.HasMany(x => x.TransactionTypes)
                .WithOne(x => x.ProxyCompany);
        }
    }
}
