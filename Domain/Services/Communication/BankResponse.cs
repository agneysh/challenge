using Challenge.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Challenge.Domain.Services.Communication
{
    public class BankResponse
    {
        public string Message { get; set; }
        public int OrderId { get; set; }

    }
}
