﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace EntityMapping
{
    class NordWindContext : DbContext
    {

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseMySql(
                "Server = localhost; Port = 3307; Database = northwind; Uid = root; Pwd = 1234;"
                );
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Ensures that the program knows of certain columns
            modelBuilder.Entity<Category>().Property(x => x.Name).HasColumnName("categoryname");
            modelBuilder.Entity<Product>().Property(x => x.Name).HasColumnName("productname");

            //Make sure that the program knows that OrderDetails has a superkey with the two foreignkeys combined
            modelBuilder.Entity<OrderDetails>()
            .HasKey(o => new { o.OrderId, o.ProductId });
        }


    }
}
