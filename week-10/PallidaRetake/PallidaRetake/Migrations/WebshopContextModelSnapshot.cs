﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using PallidaRetake.Entities;
using System;

namespace PallidaRetake.Migrations
{
    [DbContext(typeof(WebshopContext))]
    partial class WebshopContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PallidaRetake.Models.Webshop", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Catergory");

                    b.Property<string>("ItemName");

                    b.Property<string>("Manufacturer");

                    b.Property<string>("Size");

                    b.Property<double>("UnitPrice");

                    b.HasKey("Id");

                    b.ToTable("Webshop");
                });
#pragma warning restore 612, 618
        }
    }
}
