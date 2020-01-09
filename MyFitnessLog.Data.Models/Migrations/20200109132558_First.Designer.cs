﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyFitnessLog.Data.Models;

namespace MyFitnessLog.Data.Models.Migrations
{
    [DbContext(typeof(MyFitnessLogContext))]
    [Migration("20200109132558_First")]
    partial class First
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MyFitnessLog.Data.Models.Entities.WorkoutLog", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("ActivityName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("Repeatations")
                        .HasColumnType("int");

                    b.Property<int>("SetNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Workouts");
                });
#pragma warning restore 612, 618
        }
    }
}
