﻿// <auto-generated />
using System;
using ECommerce.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ECommerce.Migrations
{
    [DbContext(typeof(ECommerceDb))]
    partial class ECommerceDbModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ECommerce.Entities.Concrete.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 5, 9, 17, 26, 5, 890, DateTimeKind.Local).AddTicks(5890),
                            Name = "Electronics",
                            UpdatedAt = new DateTime(2024, 5, 9, 17, 26, 5, 890, DateTimeKind.Local).AddTicks(5920)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 5, 9, 17, 26, 5, 890, DateTimeKind.Local).AddTicks(5930),
                            Name = "Stationary",
                            UpdatedAt = new DateTime(2024, 5, 9, 17, 26, 5, 890, DateTimeKind.Local).AddTicks(5930)
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2024, 5, 9, 17, 26, 5, 890, DateTimeKind.Local).AddTicks(5930),
                            Name = "Sport",
                            UpdatedAt = new DateTime(2024, 5, 9, 17, 26, 5, 890, DateTimeKind.Local).AddTicks(5930)
                        });
                });

            modelBuilder.Entity("ECommerce.Entities.Concrete.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Category_Id")
                        .HasColumnType("int");

                    b.Property<float>("Cost")
                        .HasColumnType("real");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("Category_Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Category_Id = 1,
                            Cost = 20f,
                            CreatedAt = new DateTime(2024, 5, 9, 17, 26, 5, 890, DateTimeKind.Local).AddTicks(7890),
                            Name = "Nokia Phone",
                            UpdatedAt = new DateTime(2024, 5, 9, 17, 26, 5, 890, DateTimeKind.Local).AddTicks(7890)
                        },
                        new
                        {
                            Id = 2,
                            Category_Id = 1,
                            Cost = 2130f,
                            CreatedAt = new DateTime(2024, 5, 9, 17, 26, 5, 890, DateTimeKind.Local).AddTicks(7890),
                            Name = "Pentium 1203",
                            UpdatedAt = new DateTime(2024, 5, 9, 17, 26, 5, 890, DateTimeKind.Local).AddTicks(7890)
                        },
                        new
                        {
                            Id = 3,
                            Category_Id = 3,
                            Cost = 43f,
                            CreatedAt = new DateTime(2024, 5, 9, 17, 26, 5, 890, DateTimeKind.Local).AddTicks(7890),
                            Name = "GoalKeeper Gloves",
                            UpdatedAt = new DateTime(2024, 5, 9, 17, 26, 5, 890, DateTimeKind.Local).AddTicks(7900)
                        });
                });

            modelBuilder.Entity("ECommerce.Entities.Concrete.Product", b =>
                {
                    b.HasOne("ECommerce.Entities.Concrete.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("Category_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("ECommerce.Entities.Concrete.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
