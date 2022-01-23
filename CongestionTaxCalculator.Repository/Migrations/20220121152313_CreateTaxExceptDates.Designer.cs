﻿// <auto-generated />
using System;
using CongestionTaxCalculator.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CongestionTaxCalculator.Repository.Migrations
{
    [DbContext(typeof(CongestionTaxCalculatorDbContext))]
    [Migration("20220121152313_CreateTaxExceptDates")]
    partial class CreateTaxExceptDates
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CongestionTaxCalculator.Repository.Models.CongestionTax", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("EndTime")
                        .HasColumnType("time");

                    b.Property<TimeSpan>("StartTime")
                        .HasColumnType("time");

                    b.HasKey("Id");

                    b.ToTable("CongestionTaxes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amount = 8,
                            EndTime = new TimeSpan(0, 6, 29, 0, 0),
                            StartTime = new TimeSpan(0, 6, 0, 0, 0)
                        },
                        new
                        {
                            Id = 2,
                            Amount = 13,
                            EndTime = new TimeSpan(0, 6, 59, 0, 0),
                            StartTime = new TimeSpan(0, 6, 30, 0, 0)
                        },
                        new
                        {
                            Id = 3,
                            Amount = 18,
                            EndTime = new TimeSpan(0, 7, 59, 0, 0),
                            StartTime = new TimeSpan(0, 7, 0, 0, 0)
                        },
                        new
                        {
                            Id = 4,
                            Amount = 13,
                            EndTime = new TimeSpan(0, 8, 29, 0, 0),
                            StartTime = new TimeSpan(0, 8, 0, 0, 0)
                        },
                        new
                        {
                            Id = 5,
                            Amount = 8,
                            EndTime = new TimeSpan(0, 14, 59, 0, 0),
                            StartTime = new TimeSpan(0, 8, 30, 0, 0)
                        },
                        new
                        {
                            Id = 6,
                            Amount = 13,
                            EndTime = new TimeSpan(0, 15, 29, 0, 0),
                            StartTime = new TimeSpan(0, 15, 0, 0, 0)
                        },
                        new
                        {
                            Id = 8,
                            Amount = 18,
                            EndTime = new TimeSpan(0, 16, 59, 0, 0),
                            StartTime = new TimeSpan(0, 15, 30, 0, 0)
                        },
                        new
                        {
                            Id = 9,
                            Amount = 13,
                            EndTime = new TimeSpan(0, 17, 59, 0, 0),
                            StartTime = new TimeSpan(0, 17, 0, 0, 0)
                        },
                        new
                        {
                            Id = 10,
                            Amount = 8,
                            EndTime = new TimeSpan(0, 18, 29, 0, 0),
                            StartTime = new TimeSpan(0, 18, 0, 0, 0)
                        },
                        new
                        {
                            Id = 11,
                            Amount = 0,
                            EndTime = new TimeSpan(0, 5, 59, 0, 0),
                            StartTime = new TimeSpan(0, 18, 30, 0, 0)
                        });
                });

            modelBuilder.Entity("CongestionTaxCalculator.Repository.Models.TaxExceptDate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("TaxExceptDates");
                });

            modelBuilder.Entity("CongestionTaxCalculator.Repository.Models.TaxExemptVehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("VehicleCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VehicleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TaxExemptVehicles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            VehicleCode = "EmergencyVehicles",
                            VehicleName = "Emergency Vehicles"
                        },
                        new
                        {
                            Id = 2,
                            VehicleCode = "Busses",
                            VehicleName = "Busses"
                        },
                        new
                        {
                            Id = 3,
                            VehicleCode = "DiplomatVehicles",
                            VehicleName = "Diplomat Vehicles"
                        },
                        new
                        {
                            Id = 4,
                            VehicleCode = "Motorcycles",
                            VehicleName = "Motorcycles"
                        },
                        new
                        {
                            Id = 5,
                            VehicleCode = "MilitaryVehicles",
                            VehicleName = "Military Vehicles"
                        },
                        new
                        {
                            Id = 6,
                            VehicleCode = "ForeignVehicles",
                            VehicleName = "Foreign Vehicles"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
