﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SumOfTwoNumbers.Data;

#nullable disable

namespace SumOfTwoNumbers.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    [Migration("20220826063818_new")]
    partial class @new
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SumOfTwoNumbers.Entities.DataOfTwoNumbers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("FirstNumber")
                        .HasColumnType("int");

                    b.Property<string>("Operator")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<int>("SecondNumber")
                        .HasColumnType("int");

                    b.Property<double>("result")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("NumberData");
                });
#pragma warning restore 612, 618
        }
    }
}
