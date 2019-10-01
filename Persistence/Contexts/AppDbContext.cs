using Challenge.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Challenge.Persistence.Contexts
{
    public class AppDbContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Order>().ToTable("Orders");
            builder.Entity<Order>().HasKey(p => p.OrderId);
            builder.Entity<Order>().Property(p => p.OrderId).IsRequired().ValueGeneratedOnAdd();

            builder.Entity<Order>().Property(p => p.ClientId).IsRequired().HasMaxLength(8);
            builder.Entity<Order>().Property(p => p.CardNumber).IsRequired().HasMaxLength(16);
            builder.Entity<Order>().Property(p => p.CVV).IsRequired().HasMaxLength(16);
            builder.Entity<Order>().Property(p => p.CardExpiry).IsRequired();

            builder.Entity<Order>().Property(p => p.OrderRef).IsRequired();
            builder.Entity<Order>().Property(p => p.OrderDate).IsRequired();
            builder.Entity<Order>().Property(p => p.Amount).IsRequired();
            builder.Entity<Order>().Property(p => p.Currency).IsRequired();
            builder.Entity<Order>().Property(p => p.MerchantID).IsRequired();

            builder.Entity<Order>().HasData
            (
                new Order {
                    OrderId = 1,
                    ClientId = "CL123",
                    CardNumber = 1111222233334444,
                    CVV = 123,
                    CardExpiry = "09/2019",
                    OrderRef = "ORD1CL123",
                    OrderDate = "12/09/2019",
                    Amount = 10.00,
                    Currency = "MUR",
                    MerchantID = "MERCH1234574"
                },
                
                // Id set manually due to in-memory provider

                 new Order {
                    OrderId = 2,
                    ClientId = "CL124",
                    CardNumber = 5555666677778888,
                    CVV = 321,
                    CardExpiry = "01/2020",
                    OrderRef = "ORD2CL124",
                    OrderDate = "12/09/2019",
                    Amount = 20.00,
                    Currency = "MUR",
                    MerchantID = "MERCH1963254"
                }
            );

        }

    }
}
