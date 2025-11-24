using Identity.IdentityEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TechHub.Domain.Entities;

namespace TechHub.Infrastructure.Configurations
{
    internal class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(o => o.Id);

            builder.Property(o => o.UserId)
                .IsRequired()
                .HasMaxLength(450);

            builder.Property(o => o.OrderDate)
                .HasDefaultValueSql("GETDATE()")
                .IsRequired();

            builder.Property(o => o.Status)
                .HasConversion<string>();

            builder.Property(o => o.TotalAmount)
                .HasColumnType("decimal(18,2)");


            builder.HasOne<ApplicationUser>() 
                .WithMany(u => u.Orders)
                .HasForeignKey(o => o.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(o=>o.OrderItems)
                .WithOne(oi=>oi.Order)
                .HasForeignKey(oi=>oi.OrderId)
                .OnDelete(DeleteBehavior.Cascade);


        }
    }
}
