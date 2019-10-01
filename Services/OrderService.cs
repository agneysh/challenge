using Challenge.Domain.Models;
using Challenge.Domain.Repositories;
using Challenge.Domain.Services;
using Challenge.Domain.Services.Communication;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BankResponse = Challenge.Domain.Services.Communication.BankResponse;

namespace Challenge.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IUnitOfWork _unitOfWork;

        public OrderService(IOrderRepository orderRepository, IUnitOfWork unitOfWork)
        {
            _orderRepository = orderRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Order>> ListAsync()
        {
            return await _orderRepository.ListAsync();
        }

        public async Task<SaveOrderResponse> SaveAsync(Order order)
        {
            try
            {
                var result = await BankService.TransactionProcess(order.ClientId, order.CardNumber, order.CVV, order.CardExpiry.ToString(), order.OrderRef, order.OrderDate.ToString(), order.Amount, order.MerchantID);
                if (result.Message.ToUpper() == "SUCCESS")
                {
                    await _orderRepository.AddAsync(order);
                    await _unitOfWork.CompleteAsync();
                }

                return new SaveOrderResponse(order);
            }
            catch (Exception ex)
            {
                // Do some logging stuff
                return new SaveOrderResponse($"An error occurred when saving the Order.");
            }
        }

    }
}
