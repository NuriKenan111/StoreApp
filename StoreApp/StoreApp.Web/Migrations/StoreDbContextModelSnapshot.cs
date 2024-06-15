﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StoreApp.Data.Concrete;

#nullable disable

namespace StoreApp.Web.Migrations
{
    [DbContext(typeof(StoreDbContext))]
    partial class StoreDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.0");

            modelBuilder.Entity("StoreApp.Data.Concrete.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Category = "Phone",
                            Description = "Nice Phone",
                            Name = "Iphone 15",
                            Price = 1000m
                        },
                        new
                        {
                            Id = 2,
                            Category = "Phone",
                            Description = "Good Phone",
                            Name = "Iphone 14",
                            Price = 900m
                        },
                        new
                        {
                            Id = 3,
                            Category = "Phone",
                            Description = "Best Phone",
                            Name = "Iphone 13",
                            Price = 800m
                        },
                        new
                        {
                            Id = 4,
                            Category = "Phone",
                            Description = "Super Phone",
                            Name = "Iphone 12",
                            Price = 700m
                        },
                        new
                        {
                            Id = 5,
                            Category = "Phone",
                            Description = "Good Phone",
                            Name = "Iphone 11",
                            Price = 600m
                        },
                        new
                        {
                            Id = 6,
                            Category = "Phone",
                            Description = "Best Phone",
                            Name = "Iphone 10",
                            Price = 500m
                        },
                        new
                        {
                            Id = 7,
                            Category = "Phone",
                            Description = "Super Phone",
                            Name = "Iphone 9",
                            Price = 400m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}