using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderApp.Models
{
    public class OrderDetail
    {
        public Guid OrderDetailId { get; set; }
        public string User { get; set; }
        public string Orders { get; set; }
        public DateTime OrderedDateTime { get; set; }
        public int Amount { get; set; }
        public int Remindor { get; set; }
    }
}
