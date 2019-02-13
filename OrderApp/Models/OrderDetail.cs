using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderApp.Models
{
    public class OrderDetail
    {
        Guid id;
        public Guid Id
        {
            get
            {
                if (id == null || id == Guid.Empty)
                {
                    id = new Guid();
                }
                return id;
            }
            set
            {
                id = value;
            }
        }
        public User User { get; set; }
        public DateTime OrderedDateTime { get; set; }
        public List<PaymentDetail> Payments { get; set; }
        public int Amount { get; set; }
        public int Reminder { get; set; }
        public Order Order { get; set; }
    }
}
