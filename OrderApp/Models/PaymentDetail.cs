using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderApp.Models
{
    public class PaymentDetail
    {
        public Guid IdPayment { get; set; }

        public Payment Payment { get; set; }

        public Guid IdOrderDetail { get; set; }

        public OrderDetail OrderDetail { get; set; }
    }
}
