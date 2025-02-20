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
    [Migration("20240825182858_AddAllReation")]
    partial class AddAllReation
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

                    b.HasIndex("AirLineId");

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

                    b.HasIndex("RouteId");

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

                    b.Property<int>("Cont_Person")
                        .HasColumnType("int");

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

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("int");

                    b.HasKey("EmpId", "Qualification");

                    b.HasIndex("EmployeeId");

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

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("date")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AirLineId");

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

                    b.HasIndex("AirLineId");

                    b.ToTable("Transaction");
                });

            modelBuilder.Entity("AssEntity01.Models.AirCraft", b =>
                {
                    b.HasOne("AssEntity01.Models.AirLine", "AirLine")
                        .WithMany("AirCrafts")
                        .HasForeignKey("AirLineId");

                    b.Navigation("AirLine");
                });

            modelBuilder.Entity("AssEntity01.Models.AirCraftRoute", b =>
                {
                    b.HasOne("AssEntity01.Models.AirCraft", "AirCraft")
                        .WithMany("AirCraftRoute")
                        .HasForeignKey("AirCraftId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AssEntity01.Models.Route", "Route")
                        .WithMany("AirCraftRoute")
                        .HasForeignKey("RouteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AirCraft");

                    b.Navigation("Route");
                });

            modelBuilder.Entity("AssEntity01.Models.AirLinePhones", b =>
                {
                    b.HasOne("AssEntity01.Models.AirLine", "AirLine")
                        .WithMany("AirLinePhones")
                        .HasForeignKey("AirLineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AirLine");
                });

            modelBuilder.Entity("AssEntity01.Models.EmpQualification", b =>
                {
                    b.HasOne("AssEntity01.Models.Employee", "Employee")
                        .WithMany("EmpQualifications")
                        .HasForeignKey("EmployeeId");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("AssEntity01.Models.Employee", b =>
                {
                    b.HasOne("AssEntity01.Models.AirLine", "AirLine")
                        .WithMany("Employees")
                        .HasForeignKey("AirLineId");

                    b.Navigation("AirLine");
                });

            modelBuilder.Entity("AssEntity01.Models.Transaction", b =>
                {
                    b.HasOne("AssEntity01.Models.AirLine", "AirLine")
                        .WithMany("Transactions")
                        .HasForeignKey("AirLineId");

                    b.Navigation("AirLine");
                });

            modelBuilder.Entity("AssEntity01.Models.AirCraft", b =>
                {
                    b.Navigation("AirCraftRoute");
                });

            modelBuilder.Entity("AssEntity01.Models.AirLine", b =>
                {
                    b.Navigation("AirCrafts");

                    b.Navigation("AirLinePhones");

                    b.Navigation("Employees");

                    b.Navigation("Transactions");
                });

            modelBuilder.Entity("AssEntity01.Models.Employee", b =>
                {
                    b.Navigation("EmpQualifications");
                });

            modelBuilder.Entity("AssEntity01.Models.Route", b =>
                {
                    b.Navigation("AirCraftRoute");
                });
#pragma warning restore 612, 618
        }
    }
}
