﻿// <auto-generated />
using System;
using AssEntity01.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AssEntity01.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240825164031_InitTable")]
    partial class InitTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AssEntity01.Models.AirCraft", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AirLineId")
                        .HasColumnType("int");

                    b.Property<string>("Assistant")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Capacity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Host1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Host2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Maj_Pilot")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AirCrafts");
                });

            modelBuilder.Entity("AssEntity01.Models.AirCraftRoute", b =>
                {
                    b.Property<int?>("AirCraftId")
                        .HasColumnType("int");

                    b.Property<int?>("RouteId")
                        .HasColumnType("int");

                    b.Property<string>("Departure")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Arrival")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("numOfPass")
                        .HasColumnType("int");

                    b.HasKey("AirCraftId", "RouteId", "Departure");

                    b.ToTable("AirCraftRoute");
                });

            modelBuilder.Entity("AssEntity01.Models.AirLine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cont_Person")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AirLine");
                });

            modelBuilder.Entity("AssEntity01.Models.AirLinePhones", b =>
                {
                    b.Property<int?>("AirLineId")
                        .HasColumnType("int");

                    b.Property<int>("Phones")
                        .HasColumnType("int");

                    b.HasKey("AirLineId", "Phones");

                    b.ToTable("AirLinePhones");
                });

            modelBuilder.Entity("AssEntity01.Models.EmpQualification", b =>
                {
                    b.Property<int>("EmpId")
                        .HasColumnType("int");

                    b.Property<string>("Qualification")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("EmpId", "Qualification");

                    b.ToTable("EmpQualifications");
                });

            modelBuilder.Entity("AssEntity01.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("AirLineId")
                        .HasColumnType("int");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("date")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("AssEntity01.Models.Route", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Classification")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Destination")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Distance")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Origin")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Routes");
                });

            modelBuilder.Entity("AssEntity01.Models.Transaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AirLineId")
                        .HasColumnType("int");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Transaction");
                });
#pragma warning restore 612, 618
        }
    }
}
