using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderApp.Models
{
    public class Payment
    {
        public Guid Id { get; set; }
        public DateTime DateTime { get; set; }
        public int Amount { get; set; }
        public List<PaymentDetail> Details { get; set; }

        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}
