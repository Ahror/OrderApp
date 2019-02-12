using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderApp.Models
{
    public class User
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
        public string Login { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }
    }
}
