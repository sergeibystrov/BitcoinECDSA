﻿// <auto-generated />
using System;
using BTCECDSACracker.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BTCECDSACracker.Migrations
{
    [DbContext(typeof(BTCCrackerDBContext))]
    partial class BTCCrackerDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BTCECDSACracker.DAL.Tables.WeightLog", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Byte0")
                        .HasColumnType("int");

                    b.Property<int>("Byte1")
                        .HasColumnType("int");

                    b.Property<int>("Byte10")
                        .HasColumnType("int");

                    b.Property<int>("Byte11")
                        .HasColumnType("int");

                    b.Property<int>("Byte12")
                        .HasColumnType("int");

                    b.Property<int>("Byte13")
                        .HasColumnType("int");

                    b.Property<int>("Byte14")
                        .HasColumnType("int");

                    b.Property<int>("Byte15")
                        .HasColumnType("int");

                    b.Property<int>("Byte16")
                        .HasColumnType("int");

                    b.Property<int>("Byte17")
                        .HasColumnType("int");

                    b.Property<int>("Byte18")
                        .HasColumnType("int");

                    b.Property<int>("Byte19")
                        .HasColumnType("int");

                    b.Property<int>("Byte2")
                        .HasColumnType("int");

                    b.Property<int>("Byte20")
                        .HasColumnType("int");

                    b.Property<int>("Byte21")
                        .HasColumnType("int");

                    b.Property<int>("Byte22")
                        .HasColumnType("int");

                    b.Property<int>("Byte23")
                        .HasColumnType("int");

                    b.Property<int>("Byte24")
                        .HasColumnType("int");

                    b.Property<int>("Byte25")
                        .HasColumnType("int");

                    b.Property<int>("Byte26")
                        .HasColumnType("int");

                    b.Property<int>("Byte27")
                        .HasColumnType("int");

                    b.Property<int>("Byte28")
                        .HasColumnType("int");

                    b.Property<int>("Byte29")
                        .HasColumnType("int");

                    b.Property<int>("Byte3")
                        .HasColumnType("int");

                    b.Property<int>("Byte30")
                        .HasColumnType("int");

                    b.Property<int>("Byte31")
                        .HasColumnType("int");

                    b.Property<int>("Byte4")
                        .HasColumnType("int");

                    b.Property<int>("Byte5")
                        .HasColumnType("int");

                    b.Property<int>("Byte6")
                        .HasColumnType("int");

                    b.Property<int>("Byte7")
                        .HasColumnType("int");

                    b.Property<int>("Byte8")
                        .HasColumnType("int");

                    b.Property<int>("Byte9")
                        .HasColumnType("int");

                    b.Property<string>("WeightsHL0")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WeightsHL1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WeightsHL2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WeightsOL")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("WeightLogs");
                });
#pragma warning restore 612, 618
        }
    }
}
