﻿// <auto-generated />
using System;
using BlazorMyRide.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorMyRide.Server.Migrations
{
    [DbContext(typeof(BlazorMyRideDbContext))]
    partial class BlazorMyRideDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BlazorMyRide.Shared.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CustomId")
                        .HasColumnType("int");

                    b.Property<string>("LicensePlate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Make")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VIN")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CustomId");

                    b.ToTable("Cars");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Color = "Cafe Latte",
                            CustomId = 1,
                            LicensePlate = "T93398",
                            Make = "Kia",
                            Model = "Optima Hybrid",
                            VIN = "KNAGM4AD4G5093398"
                        },
                        new
                        {
                            Id = 2,
                            Color = "Charcoal",
                            CustomId = 2,
                            LicensePlate = "T33096",
                            Make = "Hyundai",
                            Model = "Santa Fe Sport",
                            VIN = "5XYZU3LB6EG133096"
                        });
                });

            modelBuilder.Entity("BlazorMyRide.Shared.Custom", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Customs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2023, 2, 17, 8, 11, 26, 492, DateTimeKind.Utc).AddTicks(5225),
                            Description = "Battery Repair and Replacement",
                            Price = 500.00m
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2023, 2, 17, 8, 11, 26, 492, DateTimeKind.Utc).AddTicks(5229),
                            Description = "Front side bulbs",
                            Price = 42.66m
                        });
                });

            modelBuilder.Entity("BlazorMyRide.Shared.Driver", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CarId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NationalCardNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PIN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CarId");

                    b.ToTable("Drivers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Strelbishte District",
                            CarId = 1,
                            Email = "testova.teodora@gmail.com",
                            FullName = "Teodora Testova",
                            Gender = "female",
                            NationalCardNumber = "Pending Edit",
                            PIN = "Pending Edit",
                            Phone = "123-456-789"
                        },
                        new
                        {
                            Id = 2,
                            Address = "Edit or Delete",
                            CarId = 2,
                            Email = "Edit or Delete",
                            FullName = "Edit or Delete",
                            Gender = "Edit or Delete",
                            NationalCardNumber = "Edit or Delete",
                            PIN = "Edit or Delete",
                            Phone = "Edit or Delete"
                        });
                });

            modelBuilder.Entity("BlazorMyRide.Shared.Car", b =>
                {
                    b.HasOne("BlazorMyRide.Shared.Custom", "Custom")
                        .WithMany()
                        .HasForeignKey("CustomId");

                    b.Navigation("Custom");
                });

            modelBuilder.Entity("BlazorMyRide.Shared.Driver", b =>
                {
                    b.HasOne("BlazorMyRide.Shared.Car", "Cars")
                        .WithMany()
                        .HasForeignKey("CarId");

                    b.Navigation("Cars");
                });
#pragma warning restore 612, 618
        }
    }
}
