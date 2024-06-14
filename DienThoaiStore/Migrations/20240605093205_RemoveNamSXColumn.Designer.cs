﻿// <auto-generated />
using DienThoaiStore.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DienThoaiStore.Migrations
{
    [DbContext(typeof(DienThoaiStoreContext))]
    [Migration("20240605093205_RemoveNamSXColumn")]
    partial class RemoveNamSXColumn
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DienThoaiStore.Models.Phone", b =>
                {
                    b.Property<int>("Ma")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Ma"));

                    b.Property<string>("DienThoai")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Gia")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("HeDieuHanh")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Mau")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("NamSX")
                        .HasColumnType("int");

                    b.Property<string>("ThongsoKyThuat")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Ma");

                    b.ToTable("Phone");
                });
#pragma warning restore 612, 618
        }
    }
}