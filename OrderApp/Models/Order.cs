using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderApp.Models
{
    public class Order
    {
        public Guid OrderId { get; set; }
        public DateTime Date { get; set; }
        public string Food { get; set; }
        public Guid Id { get; set; }
        public bool Closed { get; set; }
        public string Prise { get; set; }
        public int PeopleCount { get; set; }

    }
}
