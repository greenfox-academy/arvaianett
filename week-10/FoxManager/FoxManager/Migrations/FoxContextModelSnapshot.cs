﻿// <auto-generated />
using FoxManager.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace FoxManager.Migrations
{
    [DbContext(typeof(FoxContext))]
    partial class FoxContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FoxManager.Models.Class", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClassName");

                    b.Property<string>("Technology");

                    b.HasKey("Id");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("FoxManager.Models.Student", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long?>("ClassId");

                    b.Property<string>("Name");

                    b.Property<string>("Password");

                    b.Property<long?>("TeamId");

                    b.HasKey("Id");

                    b.HasIndex("ClassId");

                    b.HasIndex("TeamId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("FoxManager.Models.TaskClass", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DueDate");

                    b.Property<string>("PriorityLevel");

                    b.Property<long?>("StudentId");

                    b.Property<string>("TaskName");

                    b.Property<long?>("TeamId");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.HasIndex("TeamId");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("FoxManager.Models.Team", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("TeamName");

                    b.HasKey("Id");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("FoxManager.Models.Student", b =>
                {
                    b.HasOne("FoxManager.Models.Class", "Class")
                        .WithMany("Students")
                        .HasForeignKey("ClassId");

                    b.HasOne("FoxManager.Models.Team", "Team")
                        .WithMany("Students")
                        .HasForeignKey("TeamId");
                });

            modelBuilder.Entity("FoxManager.Models.TaskClass", b =>
                {
                    b.HasOne("FoxManager.Models.Student", "Student")
                        .WithMany("Tasks")
                        .HasForeignKey("StudentId");

                    b.HasOne("FoxManager.Models.Team", "Team")
                        .WithMany("Tasks")
                        .HasForeignKey("TeamId");
                });
#pragma warning restore 612, 618
        }
    }
}
