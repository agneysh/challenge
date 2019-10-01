using Challenge.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Challenge.Models
{
    public class OrderAPIContext : DbContext
    {
        public OrderAPIContext(DbContextOptions<OrderAPIContext> options) : base(options)
        {

        }
        public DbSet<Order> Order { get; set; }
    }
}
