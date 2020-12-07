using Foundation.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Foundation.Contexts
{
    public class RegistrationContext : DbContext, IRegistrationContext
    {
        private string _connectionString;
        private string _migrationAssemblyName;

        public RegistrationContext(string connectionString, string migrationAssemblyName)
        {
            _connectionString = connectionString;
            _migrationAssemblyName = migrationAssemblyName;
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
            //builder.Entity<Product>()
            //    .HasMany(p => p.Images)
            //    .WithOne(i => i.Product);

            //builder.Entity<ProductCategory>()
            //    .HasOne(pc => pc.Product)
            //    .WithMany(p => p.Categories)
            //    .HasForeignKey(pc => pc.ProductId);

            //builder.Entity<ProductCategory>()
            //    .HasOne(pc => pc.Category)
            //    .WithMany(c => c.Categories)
            //    .HasForeignKey(pc => pc.CategoryId);

            base.OnModelCreating(builder);
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<StudentRegistration> StuReg { get; set; }
    }
}
