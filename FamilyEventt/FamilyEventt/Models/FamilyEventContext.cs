﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FamilyEventt.Models
{
    public partial class FamilyEventContext : DbContext
    {
        public FamilyEventContext()
        {
        }

        public FamilyEventContext(DbContextOptions<FamilyEventContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Account { get; set; }
        public virtual DbSet<BookingRecord> BookingRecord { get; set; }
        public virtual DbSet<ChatMessage> ChatMessage { get; set; }
        public virtual DbSet<DateTimeLocation> DateTimeLocation { get; set; }
        public virtual DbSet<DateTimeLocationStatus> DateTimeLocationStatus { get; set; }
        public virtual DbSet<Decoration> Decoration { get; set; }
        public virtual DbSet<DecorationProduct> DecorationProduct { get; set; }
        public virtual DbSet<Drink> Drink { get; set; }
        public virtual DbSet<Entertainment> Entertainment { get; set; }
        public virtual DbSet<EntertainmentProduct> EntertainmentProduct { get; set; }
        public virtual DbSet<Event> Event { get; set; }
        public virtual DbSet<EventBooker> EventBooker { get; set; }
        public virtual DbSet<EventOrder> EventOrder { get; set; }
        public virtual DbSet<EventType> EventType { get; set; }
        public virtual DbSet<Feedback> Feedback { get; set; }
        public virtual DbSet<Food> Food { get; set; }
        public virtual DbSet<FoodType> FoodType { get; set; }
        public virtual DbSet<Game> Game { get; set; }
        public virtual DbSet<Location> Location { get; set; }
        public virtual DbSet<Menu> Menu { get; set; }
        public virtual DbSet<MenuDrink> MenuDrink { get; set; }
        public virtual DbSet<MenuProduct> MenuProduct { get; set; }
        public virtual DbSet<Payment> Payment { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Refund> Refund { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Room> Room { get; set; }
        public virtual DbSet<Script> Script { get; set; }
        public virtual DbSet<Show> Show { get; set; }
        public virtual DbSet<Staff> Staff { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.Phone).HasMaxLength(11);

                entity.Property(e => e.UserName).HasMaxLength(50);
            });

            modelBuilder.Entity<BookingRecord>(entity =>
            {
                entity.Property(e => e.BookingRecordId)
                    .ValueGeneratedNever()
                    .HasColumnName("BookingRecordID");
            });

            modelBuilder.Entity<ChatMessage>(entity =>
            {
                entity.HasKey(e => e.ChatId);

                entity.Property(e => e.ChatId)
                    .ValueGeneratedNever()
                    .HasColumnName("ChatID");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.EventBookerId).HasColumnName("EventBookerID");

                entity.Property(e => e.Message).IsRequired();

                entity.Property(e => e.StaffId).HasColumnName("StaffID");

                entity.HasOne(d => d.EventBooker)
                    .WithMany(p => p.ChatMessage)
                    .HasForeignKey(d => d.EventBookerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ChatMessage_EventBooker");
            });

            modelBuilder.Entity<DateTimeLocation>(entity =>
            {
                entity.HasKey(e => new { e.EventId, e.RoomId, e.Date });

                entity.Property(e => e.EventId).HasColumnName("EventID");

                entity.Property(e => e.RoomId).HasColumnName("RoomID");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.HasOne(d => d.Event)
                    .WithMany(p => p.DateTimeLocation)
                    .HasForeignKey(d => d.EventId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DateTimeLocation_Event");

                entity.HasOne(d => d.Room)
                    .WithMany(p => p.DateTimeLocation)
                    .HasForeignKey(d => d.RoomId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DateTimeLocation_Room");

                entity.HasOne(d => d.StatusNavigation)
                    .WithMany(p => p.DateTimeLocation)
                    .HasForeignKey(d => d.Status)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DateTimeLocation_DateTimeLocationStatus");
            });

            modelBuilder.Entity<DateTimeLocationStatus>(entity =>
            {
                entity.HasKey(e => e.StatusId);

                entity.Property(e => e.StatusId)
                    .ValueGeneratedNever()
                    .HasColumnName("StatusID");

                entity.Property(e => e.StatusName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Decoration>(entity =>
            {
                entity.Property(e => e.DecorationId)
                    .ValueGeneratedNever()
                    .HasColumnName("DecorationID");

                entity.Property(e => e.Combo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Image).IsRequired();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Price).HasColumnType("money");
            });

            modelBuilder.Entity<DecorationProduct>(entity =>
            {
                entity.HasKey(e => new { e.DecorationId, e.ProductId });

                entity.Property(e => e.DecorationId).HasColumnName("DecorationID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.HasOne(d => d.Decoration)
                    .WithMany(p => p.DecorationProduct)
                    .HasForeignKey(d => d.DecorationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DecorationProduct_Decoration");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.DecorationProduct)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DecorationProduct_Product");
            });

            modelBuilder.Entity<Drink>(entity =>
            {
                entity.HasKey(e => e.ProductId);

                entity.Property(e => e.ProductId)
                    .ValueGeneratedNever()
                    .HasColumnName("ProductID");

                entity.Property(e => e.Image).IsRequired();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Entertainment>(entity =>
            {
                entity.Property(e => e.EntertainmentId)
                    .ValueGeneratedNever()
                    .HasColumnName("EntertainmentID");

                entity.Property(e => e.EventId).HasColumnName("EventID");

                entity.Property(e => e.Total).HasColumnType("money");

                entity.HasOne(d => d.Event)
                    .WithMany(p => p.Entertainment)
                    .HasForeignKey(d => d.EventId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Entertainment_Event");
            });

            modelBuilder.Entity<EntertainmentProduct>(entity =>
            {
                entity.HasKey(e => new { e.EntertainmentId, e.ProductId })
                    .HasName("PK_EntertainmentShow");

                entity.Property(e => e.EntertainmentId).HasColumnName("EntertainmentID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.HasOne(d => d.Entertainment)
                    .WithMany(p => p.EntertainmentProduct)
                    .HasForeignKey(d => d.EntertainmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EntertainmentProduct_Entertainment");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.EntertainmentProduct)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EntertainmentProduct_Game");

                entity.HasOne(d => d.ProductNavigation)
                    .WithMany(p => p.EntertainmentProduct)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EntertainmentShow_Show");
            });

            modelBuilder.Entity<Event>(entity =>
            {
                entity.Property(e => e.EventId)
                    .ValueGeneratedNever()
                    .HasColumnName("EventID");

                entity.Property(e => e.DecorationId).HasColumnName("DecorationID");

                entity.Property(e => e.EventTypeId).HasColumnName("EventTypeID");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.RoomId).HasColumnName("RoomID");

                entity.Property(e => e.ScriptId).HasColumnName("ScriptID");

                entity.HasOne(d => d.Decoration)
                    .WithMany(p => p.Event)
                    .HasForeignKey(d => d.DecorationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Event_Decoration");

                entity.HasOne(d => d.EventType)
                    .WithMany(p => p.Event)
                    .HasForeignKey(d => d.EventTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Event_EventType");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.Event)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Event_EventOrder");

                entity.HasOne(d => d.Room)
                    .WithMany(p => p.Event)
                    .HasForeignKey(d => d.RoomId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Event_Room");

                entity.HasOne(d => d.Script)
                    .WithMany(p => p.Event)
                    .HasForeignKey(d => d.ScriptId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Event_Script");
            });

            modelBuilder.Entity<EventBooker>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.DateOfBirth).HasColumnType("date");

                entity.Property(e => e.Fullname)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<EventOrder>(entity =>
            {
                entity.HasKey(e => e.OrderId);

                entity.Property(e => e.OrderId)
                    .ValueGeneratedNever()
                    .HasColumnName("OrderID");

                entity.Property(e => e.BookingRecordId).HasColumnName("BookingRecordID");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.EventBookerId).HasColumnName("EventBookerID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Payment).IsRequired();

                entity.Property(e => e.PriceUnit).HasColumnType("money");

                entity.Property(e => e.TotalPrice).HasColumnType("money");

                entity.HasOne(d => d.BookingRecord)
                    .WithMany(p => p.EventOrder)
                    .HasForeignKey(d => d.BookingRecordId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EventOrder_BookingRecord");

                entity.HasOne(d => d.EventBooker)
                    .WithMany(p => p.EventOrder)
                    .HasForeignKey(d => d.EventBookerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EventOrder_EventBooker");
            });

            modelBuilder.Entity<EventType>(entity =>
            {
                entity.Property(e => e.EventTypeId)
                    .ValueGeneratedNever()
                    .HasColumnName("EventTypeID");

                entity.Property(e => e.Image).IsRequired();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Feedback>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.EventBookerId).HasColumnName("EventBookerID");

                entity.Property(e => e.EventId).HasColumnName("EventID");

                entity.Property(e => e.Message).IsRequired();

                entity.Property(e => e.Reply).IsRequired();
            });

            modelBuilder.Entity<Food>(entity =>
            {
                entity.HasKey(e => e.ProductId);

                entity.Property(e => e.ProductId)
                    .ValueGeneratedNever()
                    .HasColumnName("ProductID");

                entity.Property(e => e.Dish)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FoodTypeId).HasColumnName("FoodTypeID");

                entity.Property(e => e.Image).IsRequired();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Price).HasColumnType("money");

                entity.HasOne(d => d.FoodType)
                    .WithMany(p => p.Food)
                    .HasForeignKey(d => d.FoodTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Food_FoodType");
            });

            modelBuilder.Entity<FoodType>(entity =>
            {
                entity.Property(e => e.FoodTypeId)
                    .ValueGeneratedNever()
                    .HasColumnName("FoodTypeID");

                entity.Property(e => e.Detail).IsRequired();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Game>(entity =>
            {
                entity.Property(e => e.GameId)
                    .ValueGeneratedNever()
                    .HasColumnName("GameID");

                entity.Property(e => e.Details).IsRequired();

                entity.Property(e => e.Image).IsRequired();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.Reward)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Rules).IsRequired();

                entity.Property(e => e.Supplies)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.Property(e => e.LocationId)
                    .ValueGeneratedNever()
                    .HasColumnName("LocationID");

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.Image).IsRequired();

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.RoomId).HasColumnName("RoomID");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Menu>(entity =>
            {
                entity.Property(e => e.MenuId)
                    .ValueGeneratedNever()
                    .HasColumnName("MenuID");

                entity.Property(e => e.EventId).HasColumnName("EventID");

                entity.Property(e => e.PriceTotal).HasColumnType("money");

                entity.HasOne(d => d.Event)
                    .WithMany(p => p.Menu)
                    .HasForeignKey(d => d.EventId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Menu_Event");
            });

            modelBuilder.Entity<MenuDrink>(entity =>
            {
                entity.HasKey(e => new { e.MenuId, e.DrinkId });

                entity.Property(e => e.MenuId).HasColumnName("MenuID");

                entity.Property(e => e.DrinkId).HasColumnName("DrinkID");

                entity.HasOne(d => d.Drink)
                    .WithMany(p => p.MenuDrink)
                    .HasForeignKey(d => d.DrinkId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MenuDrink_Drink");

                entity.HasOne(d => d.Menu)
                    .WithMany(p => p.MenuDrink)
                    .HasForeignKey(d => d.MenuId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MenuDrink_Menu");
            });

            modelBuilder.Entity<MenuProduct>(entity =>
            {
                entity.HasKey(e => new { e.MenuId, e.Product })
                    .HasName("PK_MenuFood");

                entity.Property(e => e.MenuId).HasColumnName("MenuID");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.HasOne(d => d.Menu)
                    .WithMany(p => p.MenuProduct)
                    .HasForeignKey(d => d.MenuId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MenuFood_Menu");

                entity.HasOne(d => d.ProductNavigation)
                    .WithMany(p => p.MenuProduct)
                    .HasForeignKey(d => d.Product)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MenuProduct_Drink");

                entity.HasOne(d => d.Product1)
                    .WithMany(p => p.MenuProduct)
                    .HasForeignKey(d => d.Product)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MenuFood_Food");
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.Property(e => e.PaymentId)
                    .ValueGeneratedNever()
                    .HasColumnName("PaymentID");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.EventOrderId).HasColumnName("EventOrderID");

                entity.HasOne(d => d.EventOrder)
                    .WithMany(p => p.PaymentNavigation)
                    .HasForeignKey(d => d.EventOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Payment_EventOrder");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.ProductId)
                    .ValueGeneratedNever()
                    .HasColumnName("ProductID");

                entity.Property(e => e.Details).IsRequired();

                entity.Property(e => e.Image).IsRequired();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.Supplier)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Refund>(entity =>
            {
                entity.Property(e => e.RefundId)
                    .ValueGeneratedNever()
                    .HasColumnName("RefundID");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.PaymentId).HasColumnName("PaymentID");

                entity.HasOne(d => d.Payment)
                    .WithMany(p => p.Refund)
                    .HasForeignKey(d => d.PaymentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Refund_Payment");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.RoleId)
                    .ValueGeneratedNever()
                    .HasColumnName("RoleID");

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Room>(entity =>
            {
                entity.Property(e => e.RoomId)
                    .ValueGeneratedNever()
                    .HasColumnName("RoomID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Image)
                    .IsRequired()
                    .HasColumnType("image");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Script>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ScriptContent).IsRequired();

                entity.HasOne(d => d.EventTypeNavigation)
                    .WithMany(p => p.Script)
                    .HasForeignKey(d => d.EventType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Script_EventType");
            });

            modelBuilder.Entity<Show>(entity =>
            {
                entity.Property(e => e.ShowId)
                    .ValueGeneratedNever()
                    .HasColumnName("ShowID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Image).IsRequired();

                entity.Property(e => e.Light)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.Singer)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Sound)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Staff>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Staff)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Staff_Role");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}