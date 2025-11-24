using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TechHub.Domain.Entities;

namespace TechHub.Infrastructure.Configurations
{
    internal class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Name)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(p => p.Description)
                .IsRequired(false)
                .HasMaxLength(500);

            builder.Property(p => p.Price)
                   .IsRequired()
                   .HasColumnType("decimal(18,2)");

            builder.Property(p => p.StockQuantity)
                   .HasDefaultValue(0);

            builder.Property(p => p.VectorEmbedding)
                   .HasColumnType("vector(384)");

            builder.Property(p => p.CreatedAt)
                .HasDefaultValueSql("GETUTCDATE()");

            builder.Property(p => p.UpdatedAt)
                .IsRequired(false)
                .HasDefaultValueSql("GETUTCDATE()");

            builder.Property(p => p.ProductCategory)
                .HasConversion<string>();


        }
    }
}
