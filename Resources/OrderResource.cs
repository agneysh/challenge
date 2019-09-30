using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Challenge.Resources
{
    public class OrderResource
    {
        public int OrderId { get; set; }
        public string ClientId { get; set; }
        public string OrderRef { get; set; }
        public string OrderDate { get; set; }
        public Double Amount { get; set; }
        public string Currency { get; set; }

    }
}
