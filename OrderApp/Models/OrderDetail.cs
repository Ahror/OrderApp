using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderApp.Models
{
    public class OrderDetail
    {
        public Guid UserId { get; set; }
        public User User { get; set; }


        public Guid OrderId { get; set; }
        public Order Order { get; set; }


        public DateTime OrderedDateTime { get; set; }
        public List<PaymentDetail> Payment { get; set; }


    }
}
