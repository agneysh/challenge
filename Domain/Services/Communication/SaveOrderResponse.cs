using Challenge.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Challenge.Domain.Services.Communication
{
    public class SaveOrderResponse : BaseResponse
    {
        public Order Order { get; private set; }

        private SaveOrderResponse(bool success, string message, Order order) : base(success, message)
        {
            Order = order;
        }

        /// <summary>
        /// Creates a success response.
        /// </summary>
        /// <param name="Order">Saved Order.</param>
        /// <returns>Response.</returns>
        public SaveOrderResponse(Order order) : this(true, string.Empty, order)
        { }

        /// <summary>
        /// Creates am error response.
        /// </summary>
        /// <param name="message">Error message.</param>
        /// <returns>Response.</returns>
        public SaveOrderResponse(string message) : this(false, message, null)
        { }

    }
}
