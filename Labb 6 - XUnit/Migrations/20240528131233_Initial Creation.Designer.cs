﻿// <auto-generated />
using System;
using Labb_6___XUnit.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Labb_6___XUnit.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240528131233_Initial Creation")]
    partial class InitialCreation
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Labb_6___XUnit.CalculationHistory", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("DateOfCalculation")
                        .HasColumnType("datetime2");

                    b.Property<string>("MathOperation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Number1")
                        .HasColumnType("float");

                    b.Property<double>("Number2")
                        .HasColumnType("float");

                    b.Property<double>("Result")
                        .HasColumnType("float");

                    b.HasKey("ID");

                    b.ToTable("CalculationHistory");
                });
#pragma warning restore 612, 618
        }
    }
}
