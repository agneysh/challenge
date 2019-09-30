using Challenge.Domain.Models;
using Challenge.Domain.Services.Communication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Challenge.Domain.Services
{
    public interface IOrderService
    {
        Task<IEnumerable<Order>> ListAsync();
        Task<SaveOrderResponse> SaveAsync(Order order);
    }
}
