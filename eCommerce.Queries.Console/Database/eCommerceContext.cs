﻿using eCommerce.Models;
using Microsoft.EntityFrameworkCore;

namespace eCommerce.API.Database {
    public class eCommerceContext : DbContext {

        // Database Connection with configure enviroment
        string DBConn = "Data Source=SERVIDOR\\SQLSERVER;Initial Catalog=eCommerce;Integrated Security=True;";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer(DBConn);
        }

        // Database Connection with configure ennviroment and contructor
        public eCommerceContext(DbContextOptions<eCommerceContext> options) : base(options) { }

        // DBSets
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Contact> Contacts { get; set; } = null!;
        public DbSet<Address> Addresses { get; set; } = null!;
        public DbSet<Department> Departments { get; set; } = null!;
    }
}
