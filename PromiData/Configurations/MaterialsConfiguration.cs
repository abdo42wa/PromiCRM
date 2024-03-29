﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PromiData.Models;

namespace PromiData.Configurations.Entities
{
    public class MaterialsConfiguration : IEntityTypeConfiguration<ProductMaterial>
    {
        public void Configure(EntityTypeBuilder<ProductMaterial> builder)
        {
            builder.HasData(
                new ProductMaterial
                {
                    Id = 1,
                    ProductId = 1,
                    MaterialWarehouseId = 1,
                    Quantity = 2
                }
            );
        }
    }
}
