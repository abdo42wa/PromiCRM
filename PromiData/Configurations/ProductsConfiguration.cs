﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PromiData.Models;

namespace PromiData.Configurations.Entities
{
    public class ProductsConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product
                {
                    Id = 1,
                    //OrderId = 1,
                    Link = "sss",
                    Code = "8582262s",
                    Category = "Good",
                    Name = "Produktas",
                    LengthWithoutPackaging = 10.0,
                    WidthWithoutPackaging = 5.0,
                    HeightWithoutPackaging = 3.0,
                    LengthWithPackaging = 12.0,
                    WidthWithPackaging = 5.5,
                    HeightWithPackaging = 3.5,
                    WeightGross = 10.2,
                    WeightNetto = 9.0,
                    PackagingBoxCode = "pspspsp",
                    ImageName = "Azure",
                    ImagePath = "https://media.bitdegree.org/storage/media/images/2018/12/azure-interview-questions-logo-2-300x224.png"
                }
            );
        }
    }
}
