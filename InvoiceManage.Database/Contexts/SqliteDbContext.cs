using System;
using System.IO;
using InvoiceManage.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace InvoiceManage.Database.Contexts
{
    public class SqliteDbContext : DbContext
    {
        private readonly string _path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "InvoiceManage\\database.db");

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite($"Data Source={_path}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(SqliteDbContext).Assembly);
        }

        public DbSet<Invoice> Invoice { get; set; }
        public DbSet<InvoiceItem> InvoiceItem { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<Customer> Customer { get; set; }
    }
}