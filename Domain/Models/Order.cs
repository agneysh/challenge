using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Challenge.Domain.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string ClientId { get; set; }
        public long CardNumber { get; set; }
        public int CVV { get; set; }
        public string CardExpiry { get; set; }

        public string OrderRef { get; set; }
        public string OrderDate { get; set; }
        public double Amount { get; set; }
        public string Currency { get; set; }

        public string MerchantID { get; set; }


    }
}
