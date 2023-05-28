using Ecore.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecore.Data.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");
            builder.Property(x => x.ProductName)
                .IsRequired()
                .HasMaxLength(250);
            builder.HasIndex(x => x.ProductName)
                .IsUnique();

            //builder.HasIndex(x => x.Sku).IsUnique();

            //builder.HasIndex(x => x.Barcode).IsUnique();

            //builder.Property(x => x.WholesalePrice).HasPrecision(18, 2);
            //builder.Property(x => x.SalePrice).HasPrecision(18, 2);
            //builder.Property(x => x.ImportPrice).HasPrecision(18, 2);


            //builder.HasOne(x => x.Category)
            //    .WithMany(x => x.Products)
            //    .HasForeignKey(x => x.CategoryId);

            //builder.HasOne(x => x.Brand)
            //    .WithMany(x => x.Products)
            //    .HasForeignKey(x => x.BrandId);
        }
    }
}
