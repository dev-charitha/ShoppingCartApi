using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ShoppingCart.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.DataAccess
{
    public class ContextSC : DbContext
    {
        //public ContextSC(DbContextOptions<ContextSC> options) : base(options) { 
        //}
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            IConfigurationRoot configuration = new ConfigurationBuilder()
             .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
             .AddJsonFile("appsettings.json")
             .Build();

            optionsBuilder.UseSqlServer(configuration.GetConnectionString("OnlineShoppingDbConnection"));
        }
    }
}
