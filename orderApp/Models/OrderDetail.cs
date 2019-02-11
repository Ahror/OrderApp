using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderApp.Models
{
    public class OrderDetail
    {
        public string User { get; set; }
        public string Orders { get; set; }
        public DateTime OrderedDateTime { get; set; }
    }
}
