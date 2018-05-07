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
    [Migration("20180507185116_CustomerRating")]
    partial class CustomerRating
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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
#pragma warning restore 612, 618
        }
    }
}
