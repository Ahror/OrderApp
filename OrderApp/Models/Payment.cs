using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderApp.Models
{
    public class Payment
    {
        public Guid PaymentId { get; set; }
        public DateTime DateTime { get; set; }
        public int Amount { get; set; }
        
    }
}
