using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Challenge.Resources
{
    public class SaveOrderResource
    {
        //[Required]
        //[MaxLength(8)]
        public string ClientId { get; set; }

        //[Required]
        //[MaxLength(16)]
        public long CardNumber { get; set; }

        //[Required]
        //[MaxLength(3)]
        public int CVV { get; set; }

        //[Required]
        public string CardExpiry { get; set; }

        //[Required]
        public string OrderRef { get; set; }

        //[Required]
        public string OrderDate { get; set; }

        //[Required]
        public double Amount { get; set; }
        public string Currency { get; set; }

        //[Required]
        //[MaxLength(12)]
        public string MerchantID { get; set; }



    }
}
