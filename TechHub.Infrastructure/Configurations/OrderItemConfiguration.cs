using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TechHub.Domain.Entities;

namespace TechHub.Infrastructure.Configurations
{
    internal class OrderItemConfiguration : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            builder.HasKey(oi => new {oi.OrderId ,oi.ProductId});

            builder.Property(oi => oi.Quantity)
                   .HasDefaultValue(1);

            builder.Property(oi => oi.UnitPrice)
                    .HasColumnType("decimal(18,2)");


            builder.HasOne<Product>()
                .WithMany() 
                .HasForeignKey(oi => oi.ProductId);

        }
    }
}
