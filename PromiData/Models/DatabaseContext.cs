﻿using Microsoft.EntityFrameworkCore;
using PromiData.Configurations.Entities;

namespace PromiData.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
       : base(options)
        {
        }
        public DbSet<UserType> UserTypes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<SalesChannel> SalesChannels { get; set; }
        public DbSet<Bonus> Bonuses { get; set; }
        public DbSet<UserBonus> UserBonuses { get; set; }
        public DbSet<Country> Countries { get; set; }
        /*public DbSet<Currency> Currencies { get; set; }*/
        public DbSet<Customer> Customers { get; set; }
        public DbSet<MaterialWarehouse> MaterialsWarehouse { get; set; }
        public DbSet<ProductMaterial> ProductMaterials { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderService> OrderServices { get; set; }
        public DbSet<UserService> UserServices { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<RecentWork> RecentWorks { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Shipment> Shipments { get; set; }
        public DbSet<WarehouseCounting> WarehouseCountings { get; set; }
        public DbSet<WeeklyWorkSchedule> WeeklyWorkSchedules { get; set; }
        /*public DbSet<ProductService> ProductServices { get; set; }*/

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // make email unique
            builder.Entity<User>(entity => { entity.HasIndex(e => e.Email).IsUnique(); });
            builder.ApplyConfiguration(new UserTypesConfiguration());
            builder.ApplyConfiguration(new UsersConfiguration());
            builder.ApplyConfiguration(new CountriesConfiguration());
            builder.ApplyConfiguration(new CustomerConfiguration());
            builder.ApplyConfiguration(new ServicesConfiguration());
            builder.ApplyConfiguration(new ShipmentsConfiguration());
            builder.ApplyConfiguration(new WeeklyWorkSchedulesConfiguration());
            //KOLKAS UZKOMENTUOJU KAD PAZET KAIP VEIKIA
            /*builder.ApplyConfiguration(new OrdersConfiguration());*/
            /*builder.ApplyConfiguration(new WarehouseCountingsConfiguration());*/
            builder.ApplyConfiguration(new ProductsConfiguration());
            builder.ApplyConfiguration(new MaterialsWarehouseConfiguration());
            builder.ApplyConfiguration(new MaterialsConfiguration());
            builder.ApplyConfiguration(new OrderServicesConfiguration());
        }
    }
}
