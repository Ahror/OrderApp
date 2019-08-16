using System;
using System.Collections.Generic;

namespace OrderApp.Common.Models
{
    public class Order
    {
        public Guid Id { get; set; }

        public DateTime Date { get; set; }
        public Guid MenuId { get; set; }
        public virtual Menu Menu { get; set; }
        public bool Closed { get; set; }
        public decimal Price { get; set; }
        public int PeopleCount { get; set; }
        public virtual List<OrderDetail> Details { get; set; }

    }
}
