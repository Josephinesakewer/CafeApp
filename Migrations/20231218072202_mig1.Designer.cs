﻿// <auto-generated />
using System;
using CafeApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CafeApp.Migrations
{
    [DbContext(typeof(CafeContext))]
    [Migration("20231218072202_mig1")]
    partial class mig1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.0");

            modelBuilder.Entity("CafeApp.Models.Basket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CountDishes")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("DishId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("OrderId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("DishId");

                    b.HasIndex("OrderId");

                    b.ToTable("Baskets");
                });

            modelBuilder.Entity("CafeApp.Models.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Login")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("NameC")
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("CafeApp.Models.Dish", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("NameM")
                        .HasColumnType("TEXT");

                    b.Property<double?>("Price")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("Dishes");
                });

            modelBuilder.Entity("CafeApp.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ClientId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CookerId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("DateTimeFinish")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DateTimeStart")
                        .HasColumnType("TEXT");

                    b.Property<int?>("DelieverId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("SellerId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("StatusId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("CookerId");

                    b.HasIndex("DelieverId");

                    b.HasIndex("SellerId");

                    b.HasIndex("StatusId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("CafeApp.Models.Staff", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Staff");
                });

            modelBuilder.Entity("CafeApp.Models.StatusOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("NameS")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("StatusOrders");
                });

            modelBuilder.Entity("CafeApp.Models.Worker", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Login")
                        .HasColumnType("TEXT");

                    b.Property<string>("NameW")
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .HasColumnType("TEXT");

                    b.Property<int?>("StaffId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("StaffId");

                    b.ToTable("Workers");
                });

            modelBuilder.Entity("CafeApp.Models.Basket", b =>
                {
                    b.HasOne("CafeApp.Models.Dish", "Dish")
                        .WithMany("Baskets")
                        .HasForeignKey("DishId");

                    b.HasOne("CafeApp.Models.Order", "Order")
                        .WithMany("Baskets")
                        .HasForeignKey("OrderId");

                    b.Navigation("Dish");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("CafeApp.Models.Order", b =>
                {
                    b.HasOne("CafeApp.Models.Client", "Client")
                        .WithMany("Orders")
                        .HasForeignKey("ClientId");

                    b.HasOne("CafeApp.Models.Worker", "Cooker")
                        .WithMany("OrderCookers")
                        .HasForeignKey("CookerId");

                    b.HasOne("CafeApp.Models.Worker", "Deliever")
                        .WithMany("OrderDelievers")
                        .HasForeignKey("DelieverId");

                    b.HasOne("CafeApp.Models.Worker", "Seller")
                        .WithMany("OrderSellers")
                        .HasForeignKey("SellerId");

                    b.HasOne("CafeApp.Models.StatusOrder", "Status")
                        .WithMany("Orders")
                        .HasForeignKey("StatusId");

                    b.Navigation("Client");

                    b.Navigation("Cooker");

                    b.Navigation("Deliever");

                    b.Navigation("Seller");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("CafeApp.Models.Worker", b =>
                {
                    b.HasOne("CafeApp.Models.Staff", "Staff")
                        .WithMany("Workers")
                        .HasForeignKey("StaffId");

                    b.Navigation("Staff");
                });

            modelBuilder.Entity("CafeApp.Models.Client", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("CafeApp.Models.Dish", b =>
                {
                    b.Navigation("Baskets");
                });

            modelBuilder.Entity("CafeApp.Models.Order", b =>
                {
                    b.Navigation("Baskets");
                });

            modelBuilder.Entity("CafeApp.Models.Staff", b =>
                {
                    b.Navigation("Workers");
                });

            modelBuilder.Entity("CafeApp.Models.StatusOrder", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("CafeApp.Models.Worker", b =>
                {
                    b.Navigation("OrderCookers");

                    b.Navigation("OrderDelievers");

                    b.Navigation("OrderSellers");
                });
#pragma warning restore 612, 618
        }
    }
}
