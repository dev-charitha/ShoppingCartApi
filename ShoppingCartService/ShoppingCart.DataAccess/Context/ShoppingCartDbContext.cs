using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ShoppingCart.DataAccess.Entities;
using System;

namespace ShoppingCart.DataAccess.Context
{
    public class ShoppingCartDbContext : DbContext
    {
        public DbSet<CategoryEntity> Category { get; set; }
        public DbSet<ProductEntity> Product { get; set; }
        public DbSet<CustomerEntity> Customer { get; set; }
        public DbSet<UserEntity> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            IConfigurationRoot configuration = new ConfigurationBuilder()
             .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
             .AddJsonFile("appsettings.json")
             .Build();

            //Take Connection String from the appsettings.json File.
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("ShoppingCartDbConnection"));
        }
    }
}
