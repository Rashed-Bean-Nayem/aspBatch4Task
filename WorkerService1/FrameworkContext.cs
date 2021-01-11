
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace WorkerService1
{
    public class FrameworkContext : DbContext
    {
        private string _connectionString;
        private string _migrationAssemblyName;

        public FrameworkContext(string connectionString, string migrationAssemblyName)
        {
            _connectionString = connectionString;
            _migrationAssemblyName = migrationAssemblyName;
        }

        public FrameworkContext()
        {
            _connectionString = "Server=DESKTOP-4HQ3RMH\\SQLEXPRESS ; Database=DSCompany5 ; User=sa; Password =1110169958;";
            _migrationAssemblyName = typeof(Program).Assembly.FullName;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            if (!dbContextOptionsBuilder.IsConfigured)
            {
                dbContextOptionsBuilder.UseSqlServer(
                    _connectionString,
                    m => m.MigrationsAssembly(_migrationAssemblyName));
            }

            base.OnConfiguring(dbContextOptionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<DSCompany> company { get; set; }  
       
    }
}
