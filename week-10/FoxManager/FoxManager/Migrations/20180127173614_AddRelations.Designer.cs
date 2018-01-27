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
    [Migration("20180127173614_AddRelations")]
    partial class AddRelations
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<long?>("TeamId");

                    b.HasKey("Id");

                    b.HasIndex("TeamId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("FoxManager.Models.Task", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("DueDate");

                    b.Property<string>("PriorityLevel");

                    b.Property<long?>("StudentId");

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
                    b.HasOne("FoxManager.Models.Team", "Team")
                        .WithMany("Students")
                        .HasForeignKey("TeamId");
                });

            modelBuilder.Entity("FoxManager.Models.Task", b =>
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
