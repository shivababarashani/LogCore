using LogCore.Domain.Entities;
using LogCore.Persistence.EntityConfigs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogCore.Persistence.Contexts
{
    public class LogDbContext : DbContext
    {
        public LogDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<RequestLog> RequestLogs { get; set; }
        public DbSet<ActionLog> ActionLogs { get; set; }
        public DbSet<StateLog> StateLogs { get; set; }
        public DbSet<TransactionType> TransactionTypes { get; set; }
        public DbSet<ProxyCompany> ProxyCompanies { get; set; }
        public DbSet<LogType> LogTypes { get; set; }
        public DbSet<ApplicationType> ApplicationTypes { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new RequestLogConfig());
            modelBuilder.ApplyConfiguration(new ActionLogConfig());
            modelBuilder.ApplyConfiguration(new StateLogConfig());
            modelBuilder.ApplyConfiguration(new ApplicationTypeConfig());
            modelBuilder.ApplyConfiguration(new ProxyCompanyConfig());
            modelBuilder.ApplyConfiguration(new TransactionTypeConfig());
        }
    }
}
