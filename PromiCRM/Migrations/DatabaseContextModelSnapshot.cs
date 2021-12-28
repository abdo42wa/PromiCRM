﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PromiCRM.Models;

namespace PromiCRM.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PromiCRM.Models.Bonus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Accumulated")
                        .HasColumnType("int");

                    b.Property<int>("Bonusas")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Bonus");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Accumulated = 100,
                            Bonusas = 600,
                            Quantity = 1000,
                            UserId = new Guid("c9490c27-1b89-4e39-8f2e-99b48dcc709e")
                        });
                });

            modelBuilder.Entity("PromiCRM.Models.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Continent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Continent = "Europe",
                            Name = "Lithuania",
                            ShortName = "LT"
                        });
                });

            modelBuilder.Entity("PromiCRM.Models.Currency", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Currencies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Euras"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Doleris"
                        });
                });

            modelBuilder.Entity("PromiCRM.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CompanyName = "telia",
                            Email = "jonasv@gmail.com",
                            LastName = "Vaiciulis",
                            Name = "Jonas",
                            PhoneNumber = "860855183"
                        });
                });

            modelBuilder.Entity("PromiCRM.Models.MaterialWarehouse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DeliveryTime")
                        .HasColumnType("int");

                    b.Property<string>("ImageName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Info")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastAdittion")
                        .HasColumnType("datetime2");

                    b.Property<string>("MeasuringUnit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UseDays")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("MaterialsWarehouse");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DeliveryTime = 5,
                            Info = "viena plokste 1,5x1,5m =22500",
                            LastAdittion = new DateTime(2021, 12, 28, 15, 3, 29, 944, DateTimeKind.Local).AddTicks(4795),
                            MeasuringUnit = "cm",
                            Quantity = 22500,
                            Title = "Fanera 3mm",
                            UseDays = 40
                        });
                });

            modelBuilder.Entity("PromiCRM.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<int>("CurrencyId")
                        .HasColumnType("int");

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Device")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MoreInfo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OrderFinishDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("OrderNumber")
                        .HasColumnType("int");

                    b.Property<string>("OrderType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Platforma")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("ProductCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProductionTime")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("ShipmentTypeId")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Vat")
                        .HasColumnType("float");

                    b.Property<int>("productID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.HasIndex("CurrencyId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("ShipmentTypeId");

                    b.HasIndex("UserId");

                    b.HasIndex("productID");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Justiniskiu",
                            Comment = "great",
                            CountryId = 1,
                            CurrencyId = 1,
                            CustomerId = 1,
                            Date = new DateTime(2021, 12, 28, 15, 3, 29, 936, DateTimeKind.Local).AddTicks(362),
                            Device = "ira",
                            MoreInfo = "eeeee",
                            OrderFinishDate = new DateTime(2021, 12, 28, 15, 3, 29, 942, DateTimeKind.Local).AddTicks(3704),
                            OrderNumber = 200,
                            OrderType = "eeeee",
                            Platforma = "yeee",
                            Price = 99.989999999999995,
                            ProductCode = "123rr",
                            ProductionTime = 1,
                            Quantity = 2,
                            ShipmentTypeId = 1,
                            Status = false,
                            UserId = new Guid("c9490c27-1b89-4e39-8f2e-99b48dcc709e"),
                            Vat = 21.100000000000001,
                            productID = 1
                        });
                });

            modelBuilder.Entity("PromiCRM.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BondingTime")
                        .HasColumnType("int");

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CollectionTime")
                        .HasColumnType("int");

                    b.Property<double>("HeightWithPackaging")
                        .HasColumnType("float");

                    b.Property<double>("HeightWithoutPackaging")
                        .HasColumnType("float");

                    b.Property<string>("ImageName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("LaserTime")
                        .HasColumnType("int");

                    b.Property<double>("LengthWithPackaging")
                        .HasColumnType("float");

                    b.Property<double>("LengthWithoutPackaging")
                        .HasColumnType("float");

                    b.Property<string>("Link")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MilingTime")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PackagingBoxCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("PackingTime")
                        .HasColumnType("float");

                    b.Property<int?>("PaintingTime")
                        .HasColumnType("int");

                    b.Property<double>("WeightGross")
                        .HasColumnType("float");

                    b.Property<double>("WeightNetto")
                        .HasColumnType("float");

                    b.Property<double>("WidthWithPackaging")
                        .HasColumnType("float");

                    b.Property<double>("WidthWithoutPackaging")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BondingTime = 40,
                            Category = "Good",
                            Code = "8582262s",
                            CollectionTime = 20,
                            HeightWithPackaging = 3.5,
                            HeightWithoutPackaging = 3.0,
                            LaserTime = 10,
                            LengthWithPackaging = 12.0,
                            LengthWithoutPackaging = 10.0,
                            Link = "sss",
                            MilingTime = 20,
                            Name = "Produktas",
                            PackagingBoxCode = "pspspsp",
                            PackingTime = 10.0,
                            PaintingTime = 15,
                            WeightGross = 10.199999999999999,
                            WeightNetto = 9.0,
                            WidthWithPackaging = 5.5,
                            WidthWithoutPackaging = 5.0
                        });
                });

            modelBuilder.Entity("PromiCRM.Models.ProductMaterial", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MaterialWarehouseId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MaterialWarehouseId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductMaterials");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            MaterialWarehouseId = 1,
                            ProductId = 1,
                            Quantity = 2
                        });
                });

            modelBuilder.Entity("PromiCRM.Models.RecentWork", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int?>("Quantity")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Time")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("WorkTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("UserId");

                    b.ToTable("RecentWorks");
                });

            modelBuilder.Entity("PromiCRM.Models.SalesChannel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("BrokerageFee")
                        .HasColumnType("float");

                    b.Property<string>("ContactPerson")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeliveryAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Discount")
                        .HasColumnType("float");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("SalesChannels");
                });

            modelBuilder.Entity("PromiCRM.Models.Shipment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Period")
                        .HasColumnType("int");

                    b.Property<string>("ShipmentInfo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ShippingCost")
                        .HasColumnType("float");

                    b.Property<int>("ShippingNumber")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Shipments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Period = 2,
                            ShipmentInfo = "atidaryk ta",
                            ShippingCost = 20.399999999999999,
                            ShippingNumber = 252,
                            Type = "Express"
                        },
                        new
                        {
                            Id = 2,
                            Period = 2,
                            ShipmentInfo = "atidaryk ta",
                            ShippingCost = 20.399999999999999,
                            ShippingNumber = 252,
                            Type = "Paprastas"
                        });
                });

            modelBuilder.Entity("PromiCRM.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TypeId")
                        .HasColumnType("int");

                    b.Property<byte[]>("UserPhoto")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique()
                        .HasFilter("[Email] IS NOT NULL");

                    b.HasIndex("TypeId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c9490c27-1b89-4e39-8f2e-99b48dcc709e"),
                            Email = "promiadmin@gmail.com",
                            Name = "Adminas",
                            Password = "$2a$11$JnUvTneHfcHnhvtECOCFMuzVGRb40KJK1Dbsj7um9bP7OD/0Csz4a",
                            PhoneNumber = "860855183",
                            Surname = "Admin",
                            TypeId = 1
                        });
                });

            modelBuilder.Entity("PromiCRM.Models.UserType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UserTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Title = "ADMINISTRATOR"
                        },
                        new
                        {
                            Id = 2,
                            Title = "USER"
                        },
                        new
                        {
                            Id = 3,
                            Title = "GAMYBA"
                        },
                        new
                        {
                            Id = 4,
                            Title = "VADYBA"
                        });
                });

            modelBuilder.Entity("PromiCRM.Models.WarehouseCounting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("LastTimeChanging")
                        .HasColumnType("datetime2");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("QuantityProductWarehouse")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("WarehouseCountings");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            LastTimeChanging = new DateTime(2021, 12, 28, 15, 3, 29, 942, DateTimeKind.Local).AddTicks(7692),
                            OrderId = 1,
                            QuantityProductWarehouse = 2
                        });
                });

            modelBuilder.Entity("PromiCRM.Models.WeeklyWorkSchedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Atlikta")
                        .HasColumnType("bit");

                    b.Property<string>("DarbasApibūdinimas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("WeeklyWorkSchedules");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Atlikta = false,
                            DarbasApibūdinimas = "yeee",
                            UserId = new Guid("c9490c27-1b89-4e39-8f2e-99b48dcc709e")
                        });
                });

            modelBuilder.Entity("PromiCRM.Models.Bonus", b =>
                {
                    b.HasOne("PromiCRM.Models.User", "User")
                        .WithMany("Bonus")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("PromiCRM.Models.Order", b =>
                {
                    b.HasOne("PromiCRM.Models.Country", "Country")
                        .WithMany("Orders")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PromiCRM.Models.Currency", "Currency")
                        .WithMany("Orders")
                        .HasForeignKey("CurrencyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PromiCRM.Models.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId");

                    b.HasOne("PromiCRM.Models.Shipment", "Shipment")
                        .WithMany("Orders")
                        .HasForeignKey("ShipmentTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PromiCRM.Models.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PromiCRM.Models.Product", "Prodduct")
                        .WithMany("Order")
                        .HasForeignKey("productID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");

                    b.Navigation("Currency");

                    b.Navigation("Customer");

                    b.Navigation("Prodduct");

                    b.Navigation("Shipment");

                    b.Navigation("User");
                });

            modelBuilder.Entity("PromiCRM.Models.ProductMaterial", b =>
                {
                    b.HasOne("PromiCRM.Models.MaterialWarehouse", "MaterialWarehouse")
                        .WithMany("ProductMaterials")
                        .HasForeignKey("MaterialWarehouseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PromiCRM.Models.Product", "Product")
                        .WithMany("ProductMaterials")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MaterialWarehouse");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("PromiCRM.Models.RecentWork", b =>
                {
                    b.HasOne("PromiCRM.Models.Product", "Product")
                        .WithMany("RecentWorks")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PromiCRM.Models.User", "User")
                        .WithMany("RecentWorks")
                        .HasForeignKey("UserId");

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("PromiCRM.Models.SalesChannel", b =>
                {
                    b.HasOne("PromiCRM.Models.User", "User")
                        .WithMany("SalesChannels")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("PromiCRM.Models.User", b =>
                {
                    b.HasOne("PromiCRM.Models.UserType", "UserType")
                        .WithMany("Users")
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserType");
                });

            modelBuilder.Entity("PromiCRM.Models.WarehouseCounting", b =>
                {
                    b.HasOne("PromiCRM.Models.Order", "Order")
                        .WithMany("WarehouseCountings")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");
                });

            modelBuilder.Entity("PromiCRM.Models.WeeklyWorkSchedule", b =>
                {
                    b.HasOne("PromiCRM.Models.User", "User")
                        .WithMany("WeeklyWorkSchedules")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("PromiCRM.Models.Country", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("PromiCRM.Models.Currency", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("PromiCRM.Models.Customer", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("PromiCRM.Models.MaterialWarehouse", b =>
                {
                    b.Navigation("ProductMaterials");
                });

            modelBuilder.Entity("PromiCRM.Models.Order", b =>
                {
                    b.Navigation("WarehouseCountings");
                });

            modelBuilder.Entity("PromiCRM.Models.Product", b =>
                {
                    b.Navigation("Order");

                    b.Navigation("ProductMaterials");

                    b.Navigation("RecentWorks");
                });

            modelBuilder.Entity("PromiCRM.Models.Shipment", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("PromiCRM.Models.User", b =>
                {
                    b.Navigation("Bonus");

                    b.Navigation("Orders");

                    b.Navigation("RecentWorks");

                    b.Navigation("SalesChannels");

                    b.Navigation("WeeklyWorkSchedules");
                });

            modelBuilder.Entity("PromiCRM.Models.UserType", b =>
                {
                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
