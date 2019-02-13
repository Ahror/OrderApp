using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderApp.Models
{
    public class PaymentDetail
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


        public Payment Payment { get; set; }
        public OrderDetail OrderDetail { get; set; }
    }
}
