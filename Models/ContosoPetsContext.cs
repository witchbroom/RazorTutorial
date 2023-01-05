using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ContosoPets.Ui.Models;

public partial class ContosoPetsContext : DbContext
{
    public ContosoPetsContext()
    {
    }

    public ContosoPetsContext(DbContextOptions<ContosoPetsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<Products> Products { get; set; }

    public virtual DbSet<ProductOrder> ProductOrders { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>(entity =>
        {
            entity.Property(e => e.Email).HasDefaultValueSql("(N'')");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
