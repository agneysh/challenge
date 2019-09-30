using Challenge.Domain.Models;
using Challenge.Domain.Repositories;
using Challenge.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Challenge.Persistence.Repositories
{
    public class OrderRepository : BaseRepository, IOrderRepository
    {
        public OrderRepository(AppDbContext context): base(context) { }

        public async Task<IEnumerable<Order>> ListAsync()
        {
            return await _context.Orders.ToListAsync();
        }
        public async Task AddAsync(Order order)
        {
            await _context.Orders.AddAsync(order);
        }
    }
}
