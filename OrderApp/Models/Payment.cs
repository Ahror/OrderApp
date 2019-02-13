using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderApp.Models
{
    public class Payment
    {
        public Guid Id
        {
            get
            {
                if (Id == null || Id == Guid.Empty)
                {
                    Id = new Guid();
                }
                return Id;
            }
            set
            {
                Id = value;
            }
        }
        public DateTime DateTime { get; set; }
        public int Amount { get; set; }
        public List<PaymentDetail> Details { get; set; }
        public User User { get; set; }
    }
}
