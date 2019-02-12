using Microsoft.EntityFrameworkCore;
using OrderApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderApp.DateProvider
{
    public class OrderAppContext : DbContext

    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            


        }

        public DbSet<User> Users { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<PaymentDetail > PaymentDetails { get; set; }





















    }
}

