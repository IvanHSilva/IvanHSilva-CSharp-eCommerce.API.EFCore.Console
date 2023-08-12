using eCommerce.Models;
using Microsoft.EntityFrameworkCore;

namespace eCommerce.API.Database {
    public class eCommerceContext : DbContext {

        // Database Connection without configure enviroment
        string DBConn = "Data Source=SERVIDOR\\SQLSERVER;Initial Catalog=eCommerce;Integrated Security=True;";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer(DBConn);
                //options => options.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery))
                //.LogTo(System.Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information)
                //.EnableSensitiveDataLogging();
        }

        // DBSets
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Contact> Contacts { get; set; } = null!;
        public DbSet<Address> Addresses { get; set; } = null!;
        public DbSet<Department> Departments { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<User>().Navigation(u => u.Contact).AutoInclude();
        }
    }
}
