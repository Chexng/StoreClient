﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProductApi;

#nullable disable

namespace StoreApi.Migrations
{
    [DbContext(typeof(SqlDbContext))]
    partial class SqlDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ProductLib.Pricing", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EffectedFrom")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LastUpdatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("ProductId")
                        .IsRequired()
                        .HasColumnType("varchar(36)");

                    b.Property<double>("Value")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Pricing");
                });

            modelBuilder.Entity("ProductLib.Product", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(36)
                        .IsUnicode(false)
                        .HasColumnType("varchar(36)")
                        .HasColumnName("Id");

                    b.Property<byte>("Category")
                        .HasColumnType("tinyint")
                        .HasColumnName("Category");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("Code");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime")
                        .HasColumnName("CreatedOn");

                    b.Property<DateTime?>("LastUpdatedOn")
                        .HasColumnType("datetime")
                        .HasColumnName("LastUpdatedOn");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Name");

                    b.HasKey("Id");

                    b.HasIndex("Code")
                        .IsUnique();

                    b.ToTable("Products", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "89a83a5a-38df-40fc-ba43-a4a8e6264fcb",
                            Category = (byte)4,
                            Code = "PRD001",
                            CreatedOn = new DateTime(2023, 12, 14, 11, 12, 56, 17, DateTimeKind.Local).AddTicks(2833),
                            Name = "Nike Jacket"
                        },
                        new
                        {
                            Id = "b87be491-69ba-4be1-8234-cb0a612dfcbd",
                            Category = (byte)1,
                            Code = "PRD002",
                            CreatedOn = new DateTime(2023, 12, 14, 11, 12, 56, 17, DateTimeKind.Local).AddTicks(2851),
                            Name = "Puma Shirt"
                        });
                });

            modelBuilder.Entity("ProductLib.Staff", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(36)
                        .IsUnicode(false)
                        .HasColumnType("varchar(36)")
                        .HasColumnName("Id");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime")
                        .HasColumnName("CreatedOn");

                    b.Property<DateTime>("EffectedFrom")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LastUpdatedOn")
                        .HasColumnType("datetime")
                        .HasColumnName("LastUpdatedOn");

                    b.Property<byte>("Position")
                        .HasColumnType("tinyint")
                        .HasColumnName("Position");

                    b.Property<string>("SName")
                        .HasMaxLength(50)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("SName");

                    b.Property<string>("StaffId")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("StaffId");

                    b.HasKey("Id");

                    b.HasIndex("StaffId")
                        .IsUnique();

                    b.ToTable("Staffs", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "0abf92d7-d58c-4bb5-9c17-bc217968274f",
                            CreatedOn = new DateTime(2023, 12, 14, 11, 12, 56, 18, DateTimeKind.Local).AddTicks(152),
                            EffectedFrom = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Position = (byte)2,
                            SName = "Rothna",
                            StaffId = "STF001"
                        });
                });

            modelBuilder.Entity("ProductLib.Pricing", b =>
                {
                    b.HasOne("ProductLib.Product", "Product")
                        .WithMany("Pricings")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("ProductLib.Product", b =>
                {
                    b.Navigation("Pricings");
                });
#pragma warning restore 612, 618
        }
    }
}
