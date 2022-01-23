﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PromiCRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PromiCRM.Configurations.Entities
{
    public class OrdersConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            var id = Guid.Parse("c9490c27-1b89-4e39-8f2e-99b48dcc709e");
            builder.HasData(
                new Order
                {
                    Id = 1,
                    ProductId = 1,
                    UserId = id,
                    OrderNumber = 200,
                    Date = DateTime.Now,
                    Platforma = "yeee",
                    MoreInfo = "eeeee",
                    OrderType = "Standartinis",
                    Quantity = 2,
                    ProductCode = "8582262s",
                    ShipmentTypeId = 1,
                    CustomerId = 1,
                    Address = "Justiniskiu",
                    CountryId = 1,
                    ProductionTime = 1,
                    Comment = "great",
                    Device = "ira",
                    Price = 99.99,
                    CurrencyId = 1,
                    Vat = 21.1,
                    Status= false,
                    OrderFinishDate = DateTime.Now,
                    BondingTime = 40,
                    CollectionTime = 20,
                    LaserTime = 10,
                    MilingTime = 20,
                    PaintingTime = 15,
                    PackingTime = 10,
                }
            );
        }
    }
}
