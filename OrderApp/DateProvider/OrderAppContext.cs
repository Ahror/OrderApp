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
            OrderMapping(modelBuilder);
            
        }

        void OrderMapping(ModelBuilder builder)
        {
            
            var etBuilder = builder.Entity<Order>();
            etBuilder.ToTable("Order");
            etBuilder.HasKey(o => new { o.Id });
            etBuilder.Property(o => o.Id).HasColumnName("Id");
            etBuilder.Property(o => o.Date).HasColumnName("Date");
            etBuilder.Property(o => o.Closed  ).HasColumnName("Closed");
            etBuilder.Property(o => o.Price).HasColumnName("Price");
            etBuilder.Property(o => o.PeopleCount).HasColumnName("PeopleCount");
            etBuilder.HasOne(o => o.Food);
            etBuilder.HasMany(o => o.Details).WithOne(d => d.Order);

        }


        public DbSet<User> Users { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public  DbSet<Payment> Payments { get; set; }
        public DbSet<PaymentDetail> PaymentDetails { get; set; }
               
    }
}
