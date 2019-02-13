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
            MenuMapping(modelBuilder);
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
        void MenuMapping(ModelBuilder builder )
        {
            var etBuilder = builder.Entity<Menu>();
            etBuilder.ToTable("Menu");
            etBuilder.HasKey(m => new { m.Id  });
            etBuilder.Property(m =>  m.Id).HasColumnName("Id");
            etBuilder.Property(m => m.Name ).HasColumnName("Name");
            etBuilder.Property(m => m.Description ).HasColumnName("Description");

        }
        void UserMapping(ModelBuilder builder)
        {
            var etBuilder = builder.Entity<User>();
            etBuilder.ToTable("User");
            etBuilder.HasKey(u => new { u.Id });
            etBuilder.Property(u => u.Id).HasColumnName("Id");
            etBuilder.Property(u => u.Login ).HasColumnName("Login");
            etBuilder.Property(u => u.Password ).HasColumnName("Password");
            etBuilder.Property(u => u.IsAdmin ).HasColumnName("IsAdmin");



        }


        public DbSet<User> Users { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<PaymentDetail > PaymentDetails { get; set; }





















    }
}

