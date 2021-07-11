﻿// <auto-generated />
using System;
using Aliquota.Domain.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Aliquota.Domain.Migrations
{
    [DbContext(typeof(AliquotaDbContext))]
    [Migration("20210711031717_RemoveFielRescueValueAndAddFieldFirstInvestmentDate")]
    partial class RemoveFielRescueValueAndAddFieldFirstInvestmentDate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.7");

            modelBuilder.Entity("Aliquota.Domain.Models.Investment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("VARCHAR(80)");

                    b.Property<DateTime>("FirstInvestmentDate")
                        .HasColumnType("DATE");

                    b.Property<DateTime>("InvestmentDate")
                        .HasColumnType("DATE");

                    b.Property<DateTime?>("RescueDate")
                        .HasColumnType("DATE");

                    b.Property<decimal>("Value")
                        .HasColumnType("DECIMAL(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Investments");
                });
#pragma warning restore 612, 618
        }
    }
}
