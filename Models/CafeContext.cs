using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CafeApp.Models;

public class CafeContext : DbContext
{
 

    public CafeContext(DbContextOptions<CafeContext> options)
        : base(options)
    {
        Database.EnsureCreated();
    }

    public DbSet<Client> Clients { get; set; }

    public DbSet<Dish> Dishes { get; set; }

    public DbSet<Order> Orders { get; set; }

    public DbSet<OrderDish> OrderDishes { get; set; }

    public DbSet<Staff> Staff { get; set; }

    public DbSet<StatusOrder> StatusOrders { get; set; }

    public DbSet<Worker> Workers { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Order>().
            HasOne(o => o.Cooker).
            WithMany(w => w.OrderCookers).
            HasForeignKey(o => o.CookerId);
        modelBuilder.Entity<Order>().
            HasOne(o => o.Deliever).
            WithMany(w => w.OrderDelievers).
            HasForeignKey(o => o.DelieverId);
        modelBuilder.Entity<Order>().
            HasOne(o => o.Seller).
            WithMany(w => w.OrderSellers).
            HasForeignKey(o => o.SellerId);
    }

}
