using InvoiceManage.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace InvoiceManage.Database.Contexts
{
    public class SqlServerContext : DbContext
    {
        private const string ErrConnectionString =
            "Data Source=.;Initial Catalog=InvoiceManage;Persist Security Info=True;User ID=sa;password=;Connection Timeout=3600;Encrypt=false;";

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(ErrConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(SqlServerContext).Assembly);
        }

        public DbSet<Invoice> Invoice { get; set; }
        public DbSet<InvoiceItem> InvoiceItem { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<Customer> Customer { get; set; }
    }
}