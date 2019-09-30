using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Challenge.Domain.Models;


namespace Challenge.Domain.Repositories
{
    public interface IOrderRepository
    {
        Task<IEnumerable<Order>> ListAsync();
        Task AddAsync(Order order);
    }
}
