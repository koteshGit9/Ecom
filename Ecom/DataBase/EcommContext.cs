using Ecom.Entity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Ecom.DataBase
{
    
        public class EcommContext : DbContext
        {
            public DbSet<User>? Users { get; set; }

            public DbSet<Product> Products { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer("Data Source = MSI\\SQLEXPRESS; Initial Catalog= Ecomm;User Id=Kotesh;Password=Kolli@123;TrustServerCertificate=true");
                base.OnConfiguring(optionsBuilder);
            }
        }
    }

