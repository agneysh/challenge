using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Challenge.Domain.Models;
using Challenge.Domain.Services;
using AutoMapper;
using Challenge.Resources;
using Challenge.Extensions;

namespace Challenge.Controllers
{
    [Route("/api/[controller]")]
    public class OrdersController : Controller
    {

        private readonly IOrderService _orderService;
        private readonly IMapper _mapper;

        public OrdersController(IOrderService orderService, IMapper mapper)
        {
            _orderService = orderService;
            _mapper = mapper;
        }


        // GET: api/Orders
        [HttpGet]
        public async Task<IEnumerable<OrderResource>> GetAllAsync()
        {
            var orders = await _orderService.ListAsync();
            var resources = _mapper.Map<IEnumerable<Order>, IEnumerable<OrderResource>>(orders);

            return resources;
        }

        // POST: api/Orders
        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] SaveOrderResource resource)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.GetErrorMessages());

            var order = _mapper.Map<SaveOrderResource, Order>(resource);
            var result = await _orderService.SaveAsync(order);

            if (!result.Success)
                return BadRequest(result.Message);

            var orderResource = _mapper.Map<Order, OrderResource>(result.Order);
            return Ok(orderResource);

        }
    }
}
