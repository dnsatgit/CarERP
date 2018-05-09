﻿// <auto-generated />
using CarERPFinal.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace CarERPFinal.Migrations
{
    [DbContext(typeof(CarERPFinalContext))]
    partial class CarERPFinalContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CarERPFinal.Models.Customer", b =>
                {
                    b.Property<int>("CustomerID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<DateTime>("DOB");

                    b.Property<string>("FirstNameMI");

                    b.Property<string>("LastName");

                    b.Property<string>("PhoneNumber");

                    b.Property<string>("UserName");

                    b.Property<string>("password");

                    b.HasKey("CustomerID");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("CarERPFinal.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FirstNameMI");

                    b.Property<string>("LastName");

                    b.Property<bool>("RequestValidation");

                    b.Property<int?>("requestsRequestID");

                    b.HasKey("EmployeeID");

                    b.HasIndex("requestsRequestID");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("CarERPFinal.Models.Request", b =>
                {
                    b.Property<int>("RequestID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Cost");

                    b.Property<string>("CustomerID");

                    b.Property<int?>("CustomerID1");

                    b.Property<string>("Description");

                    b.Property<string>("ServiceID");

                    b.Property<string>("Vehicle");

                    b.Property<int?>("serviceID");

                    b.HasKey("RequestID");

                    b.HasIndex("CustomerID1");

                    b.HasIndex("serviceID");

                    b.ToTable("Request");
                });

            modelBuilder.Entity("CarERPFinal.Models.Services", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CustomerRating");

                    b.Property<DateTime>("ListedDate");

                    b.Property<decimal>("Price");

                    b.Property<string>("ServiceName");

                    b.Property<string>("ServiceType");

                    b.HasKey("ID");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("CarERPFinal.Models.Employee", b =>
                {
                    b.HasOne("CarERPFinal.Models.Request", "requests")
                        .WithMany()
                        .HasForeignKey("requestsRequestID");
                });

            modelBuilder.Entity("CarERPFinal.Models.Request", b =>
                {
                    b.HasOne("CarERPFinal.Models.Customer", "customer")
                        .WithMany()
                        .HasForeignKey("CustomerID1");

                    b.HasOne("CarERPFinal.Models.Services", "service")
                        .WithMany("Requests")
                        .HasForeignKey("serviceID");
                });
#pragma warning restore 612, 618
        }
    }
}
