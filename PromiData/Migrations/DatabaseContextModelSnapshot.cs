﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PromiData.Models;

namespace PromiData.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.14")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PromiData.Models.Bonus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Accumulated")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("IndividualBonusQuantity")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("Reward")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Bonuses");
                });

            modelBuilder.Entity("PromiData.Models.Country", b =>
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

            modelBuilder.Entity("PromiData.Models.Customer", b =>
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

            modelBuilder.Entity("PromiData.Models.MaterialWarehouse", b =>
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
                            LastAdittion = new DateTime(2022, 3, 16, 11, 10, 6, 490, DateTimeKind.Local).AddTicks(3511),
                            MeasuringUnit = "cm",
                            Quantity = 22500,
                            Title = "Fanera 3mm",
                            UseDays = 40
                        });
                });

            modelBuilder.Entity("PromiData.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CompletionDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("CountryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CurrencyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("CustomerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Defective")
                        .HasColumnType("bit");

                    b.Property<int>("DefectiveNumber")
                        .HasColumnType("int");

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

                    b.Property<double?>("Price")
                        .HasColumnType("float");

                    b.Property<string>("ProductCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("ProductionTime")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int?>("ShipmentTypeId")
                        .HasColumnType("int");

                    b.Property<string>("ShippingCost")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShippingNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double?>("Vat")
                        .HasColumnType("float");

                    b.Property<DateTime?>("WarehouseProductsDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("WarehouseProductsNumber")
                        .HasColumnType("int");

                    b.Property<bool>("WarehouseProductsTaken")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("ProductId");

                    b.HasIndex("ShipmentTypeId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("PromiData.Models.OrderService", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("OrderId")
                        .HasColumnType("int");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("ServiceId")
                        .HasColumnType("int");

                    b.Property<int>("TimeConsumption")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.HasIndex("ServiceId");

                    b.ToTable("OrderServices");
                });

            modelBuilder.Entity("PromiData.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("HeightWithPackaging")
                        .HasColumnType("float");

                    b.Property<double>("HeightWithoutPackaging")
                        .HasColumnType("float");

                    b.Property<string>("ImageName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("LengthWithPackaging")
                        .HasColumnType("float");

                    b.Property<double>("LengthWithoutPackaging")
                        .HasColumnType("float");

                    b.Property<string>("Link")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PackagingBoxCode")
                        .HasColumnType("nvarchar(max)");

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
                            Category = "Good",
                            Code = "8582262s",
                            HeightWithPackaging = 3.5,
                            HeightWithoutPackaging = 3.0,
                            ImageName = "Azure",
                            ImagePath = "https://media.bitdegree.org/storage/media/images/2018/12/azure-interview-questions-logo-2-300x224.png",
                            LengthWithPackaging = 12.0,
                            LengthWithoutPackaging = 10.0,
                            Link = "sss",
                            Name = "Produktas",
                            PackagingBoxCode = "pspspsp",
                            WeightGross = 10.199999999999999,
                            WeightNetto = 9.0,
                            WidthWithPackaging = 5.5,
                            WidthWithoutPackaging = 5.0
                        });
                });

            modelBuilder.Entity("PromiData.Models.ProductMaterial", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MaterialWarehouseId")
                        .HasColumnType("int");

                    b.Property<int?>("OrderId")
                        .HasColumnType("int");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<DateTime>("RegisterDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("MaterialWarehouseId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductMaterials");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            MaterialWarehouseId = 1,
                            ProductId = 1,
                            Quantity = 2,
                            RegisterDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("PromiData.Models.RecentWork", b =>
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

            modelBuilder.Entity("PromiData.Models.SalesChannel", b =>
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

            modelBuilder.Entity("PromiData.Models.Service", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Services");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Lazeriavimas"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Frezavimas"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Dažymas"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Šlifavimas"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Suklijavimas"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Surinkimas"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Pakavimas"
                        });
                });

            modelBuilder.Entity("PromiData.Models.Shipment", b =>
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

            modelBuilder.Entity("PromiData.Models.User", b =>
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
                            Password = "$2a$11$6nyy2L.yNmazUCiJ/5iTOevbww8QuRR6/5/x0wc20CXkg..jgUXVi",
                            PhoneNumber = "860855183",
                            Surname = "Admin",
                            TypeId = 1
                        });
                });

            modelBuilder.Entity("PromiData.Models.UserBonus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BonusId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Reward")
                        .HasColumnType("int");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("BonusId");

                    b.HasIndex("UserId");

                    b.ToTable("UserBonuses");
                });

            modelBuilder.Entity("PromiData.Models.UserService", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CompletionDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("OrderServiceId")
                        .HasColumnType("int");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("OrderServiceId");

                    b.HasIndex("UserId");

                    b.ToTable("UserServices");
                });

            modelBuilder.Entity("PromiData.Models.UserType", b =>
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

            modelBuilder.Entity("PromiData.Models.WarehouseCounting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImageName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastTimeChanging")
                        .HasColumnType("datetime2");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<string>("ProductCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QuantityProductWarehouse")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("WarehouseCountings");
                });

            modelBuilder.Entity("PromiData.Models.WeeklyWorkSchedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Done")
                        .HasColumnType("bit");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("WeeklyWorkSchedules");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Date = new DateTime(2022, 3, 16, 11, 10, 6, 484, DateTimeKind.Local).AddTicks(507),
                            Description = "Supildyti frezavimo laiko lentele",
                            Done = false,
                            UserId = new Guid("c9490c27-1b89-4e39-8f2e-99b48dcc709e")
                        });
                });

            modelBuilder.Entity("PromiData.Models.Order", b =>
                {
                    b.HasOne("PromiData.Models.Country", "Country")
                        .WithMany("Orders")
                        .HasForeignKey("CountryId");

                    b.HasOne("PromiData.Models.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId");

                    b.HasOne("PromiData.Models.Product", "Product")
                        .WithMany("Orders")
                        .HasForeignKey("ProductId");

                    b.HasOne("PromiData.Models.Shipment", "Shipment")
                        .WithMany("Orders")
                        .HasForeignKey("ShipmentTypeId");

                    b.HasOne("PromiData.Models.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");

                    b.Navigation("Customer");

                    b.Navigation("Product");

                    b.Navigation("Shipment");

                    b.Navigation("User");
                });

            modelBuilder.Entity("PromiData.Models.OrderService", b =>
                {
                    b.HasOne("PromiData.Models.Order", "Order")
                        .WithMany("OrderServices")
                        .HasForeignKey("OrderId");

                    b.HasOne("PromiData.Models.Product", "Product")
                        .WithMany("OrderServices")
                        .HasForeignKey("ProductId");

                    b.HasOne("PromiData.Models.Service", "Service")
                        .WithMany("OrderServices")
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");

                    b.Navigation("Service");
                });

            modelBuilder.Entity("PromiData.Models.ProductMaterial", b =>
                {
                    b.HasOne("PromiData.Models.MaterialWarehouse", "MaterialWarehouse")
                        .WithMany("ProductMaterials")
                        .HasForeignKey("MaterialWarehouseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PromiData.Models.Order", "Order")
                        .WithMany("ProductMaterials")
                        .HasForeignKey("OrderId");

                    b.HasOne("PromiData.Models.Product", "Product")
                        .WithMany("ProductMaterials")
                        .HasForeignKey("ProductId");

                    b.Navigation("MaterialWarehouse");

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("PromiData.Models.RecentWork", b =>
                {
                    b.HasOne("PromiData.Models.Product", "Product")
                        .WithMany("RecentWorks")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PromiData.Models.User", "User")
                        .WithMany("RecentWorks")
                        .HasForeignKey("UserId");

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("PromiData.Models.SalesChannel", b =>
                {
                    b.HasOne("PromiData.Models.User", "User")
                        .WithMany("SalesChannels")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("PromiData.Models.User", b =>
                {
                    b.HasOne("PromiData.Models.UserType", "UserType")
                        .WithMany("Users")
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserType");
                });

            modelBuilder.Entity("PromiData.Models.UserBonus", b =>
                {
                    b.HasOne("PromiData.Models.Bonus", null)
                        .WithMany("UserBonuses")
                        .HasForeignKey("BonusId");

                    b.HasOne("PromiData.Models.User", "User")
                        .WithMany("UserBonuses")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("PromiData.Models.UserService", b =>
                {
                    b.HasOne("PromiData.Models.Order", "Order")
                        .WithMany("UserServices")
                        .HasForeignKey("OrderId");

                    b.HasOne("PromiData.Models.OrderService", "OrderService")
                        .WithMany("UserServices")
                        .HasForeignKey("OrderServiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PromiData.Models.User", "User")
                        .WithMany("UserServices")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("OrderService");

                    b.Navigation("User");
                });

            modelBuilder.Entity("PromiData.Models.WarehouseCounting", b =>
                {
                    b.HasOne("PromiData.Models.Order", "Order")
                        .WithMany("WarehouseCountings")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");
                });

            modelBuilder.Entity("PromiData.Models.WeeklyWorkSchedule", b =>
                {
                    b.HasOne("PromiData.Models.User", "User")
                        .WithMany("WeeklyWorkSchedules")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("PromiData.Models.Bonus", b =>
                {
                    b.Navigation("UserBonuses");
                });

            modelBuilder.Entity("PromiData.Models.Country", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("PromiData.Models.Customer", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("PromiData.Models.MaterialWarehouse", b =>
                {
                    b.Navigation("ProductMaterials");
                });

            modelBuilder.Entity("PromiData.Models.Order", b =>
                {
                    b.Navigation("OrderServices");

                    b.Navigation("ProductMaterials");

                    b.Navigation("UserServices");

                    b.Navigation("WarehouseCountings");
                });

            modelBuilder.Entity("PromiData.Models.OrderService", b =>
                {
                    b.Navigation("UserServices");
                });

            modelBuilder.Entity("PromiData.Models.Product", b =>
                {
                    b.Navigation("Orders");

                    b.Navigation("OrderServices");

                    b.Navigation("ProductMaterials");

                    b.Navigation("RecentWorks");
                });

            modelBuilder.Entity("PromiData.Models.Service", b =>
                {
                    b.Navigation("OrderServices");
                });

            modelBuilder.Entity("PromiData.Models.Shipment", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("PromiData.Models.User", b =>
                {
                    b.Navigation("Orders");

                    b.Navigation("RecentWorks");

                    b.Navigation("SalesChannels");

                    b.Navigation("UserBonuses");

                    b.Navigation("UserServices");

                    b.Navigation("WeeklyWorkSchedules");
                });

            modelBuilder.Entity("PromiData.Models.UserType", b =>
                {
                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
