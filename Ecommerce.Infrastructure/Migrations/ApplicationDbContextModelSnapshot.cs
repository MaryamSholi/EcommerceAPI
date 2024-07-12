﻿// <auto-generated />
using System;
using Ecommerce.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Ecommerce.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.31")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Ecommerce.Core.Entities.Categories", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Devices and gadgets",
                            Name = "Electronics"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Books and literature",
                            Name = "Books"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Apparel and accessories",
                            Name = "Clothing"
                        });
                });

            modelBuilder.Entity("Ecommerce.Core.Entities.LocalUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("LocalUser");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Ahmed Haggag",
                            Password = "password123",
                            Role = "Admin",
                            UserName = "Haggag281"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Tarek Sharim",
                            Password = "password456",
                            Role = "User",
                            UserName = "Tarek777"
                        });
                });

            modelBuilder.Entity("Ecommerce.Core.Entities.OrderDetails", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Quantity")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id", "ProductId", "OrderId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDetails");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ProductId = 1,
                            OrderId = 1,
                            Price = 299.99m,
                            Quantity = 1m
                        },
                        new
                        {
                            Id = 2,
                            ProductId = 4,
                            OrderId = 1,
                            Price = 9.99m,
                            Quantity = 2m
                        },
                        new
                        {
                            Id = 3,
                            ProductId = 3,
                            OrderId = 2,
                            Price = 19.99m,
                            Quantity = 1m
                        },
                        new
                        {
                            Id = 4,
                            ProductId = 2,
                            OrderId = 3,
                            Price = 799.99m,
                            Quantity = 1m
                        },
                        new
                        {
                            Id = 5,
                            ProductId = 5,
                            OrderId = 3,
                            Price = 9.99m,
                            Quantity = 1m
                        });
                });

            modelBuilder.Entity("Ecommerce.Core.Entities.Orders", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("LocalUserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("OrderStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LocalUserId");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            LocalUserId = 1,
                            OrderDate = new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OrderStatus = "Pending"
                        },
                        new
                        {
                            Id = 2,
                            LocalUserId = 2,
                            OrderDate = new DateTime(2023, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OrderStatus = "Completed"
                        },
                        new
                        {
                            Id = 3,
                            LocalUserId = 1,
                            OrderDate = new DateTime(2023, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OrderStatus = "Shipped"
                        });
                });

            modelBuilder.Entity("Ecommerce.Core.Entities.Products", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Image = "smartphone.jpg",
                            Name = "Smartphone",
                            Price = 299.99m
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Image = "laptop.jpg",
                            Name = "Laptop",
                            Price = 799.99m
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 2,
                            Image = "novel.jpg",
                            Name = "Novel",
                            Price = 19.99m
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 3,
                            Image = "tshirt.jpg",
                            Name = "T-Shirt",
                            Price = 9.99m
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 3,
                            Image = "jeans.jpg",
                            Name = "Jeans",
                            Price = 49.99m
                        });
                });

            modelBuilder.Entity("Ecommerce.Core.Entities.OrderDetails", b =>
                {
                    b.HasOne("Ecommerce.Core.Entities.Orders", "Orders")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ecommerce.Core.Entities.Products", "Products")
                        .WithMany("OrderDetails")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Orders");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("Ecommerce.Core.Entities.Orders", b =>
                {
                    b.HasOne("Ecommerce.Core.Entities.LocalUser", "LocalUser")
                        .WithMany("Orders")
                        .HasForeignKey("LocalUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LocalUser");
                });

            modelBuilder.Entity("Ecommerce.Core.Entities.Products", b =>
                {
                    b.HasOne("Ecommerce.Core.Entities.Categories", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Ecommerce.Core.Entities.Categories", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Ecommerce.Core.Entities.LocalUser", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Ecommerce.Core.Entities.Orders", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("Ecommerce.Core.Entities.Products", b =>
                {
                    b.Navigation("OrderDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
