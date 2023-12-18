using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CafeApp.Models;

public class CafeContext : DbContext
{
    public CafeContext() :base() { }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
     => optionsBuilder.UseSqlite("Data Source=cafe.db");

    public CafeContext(DbContextOptions options)
        : base(options)
    {
        Database.EnsureCreated();
    }

    public DbSet<Client> Clients { get; set; }

    public DbSet<Dish> Dishes { get; set; }

    public DbSet<Order> Orders { get; set; }

    public DbSet<Basket> Baskets { get; set; }

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
        modelBuilder.Entity<Order>().
            HasMany(o => o.Dishes).
            WithMany(d => d.Orders).
            UsingEntity<Basket>(
            b=> b.
                HasOne(bt => bt.Dish).
                WithMany( d=> d.Baskets).
                HasForeignKey(bt => bt.DishId),
            b => b.
                HasOne( bt => bt.Order).
                WithMany( o =>o.Baskets).
                HasForeignKey(bt => bt.OrderId)
            
            );
    }

}
