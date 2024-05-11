﻿// <auto-generated />
using System;
using HotelMS.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HotelMS.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HotelMS.Domain.Entities.Hotel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Website")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Hotels");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "21 Robin Street",
                            CreatedAt = new DateTime(2024, 5, 11, 4, 19, 27, 134, DateTimeKind.Utc).AddTicks(4779),
                            Email = "robin.correa21@gmail.com",
                            Name = "Default Hotel",
                            Phone = "1121-1121-1121",
                            UpdatedAt = new DateTime(2024, 5, 11, 4, 19, 27, 134, DateTimeKind.Utc).AddTicks(4786),
                            Website = "http://robincorrea.com"
                        });
                });

            modelBuilder.Entity("HotelMS.Domain.Entities.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("HotelId")
                        .HasColumnType("int");

                    b.Property<string>("RoomNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("HotelId");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("HotelMS.Domain.Entities.RoomCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TotalAdult")
                        .HasColumnType("int");

                    b.Property<int>("TotalCapacity")
                        .HasColumnType("int");

                    b.Property<int>("TotalChild")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("RoomCategories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 5, 11, 4, 19, 27, 134, DateTimeKind.Utc).AddTicks(4924),
                            Description = "Standard room",
                            Name = "Standard",
                            TotalAdult = 2,
                            TotalCapacity = 2,
                            TotalChild = 1,
                            UpdatedAt = new DateTime(2024, 5, 11, 4, 19, 27, 134, DateTimeKind.Utc).AddTicks(4926)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 5, 11, 4, 19, 27, 134, DateTimeKind.Utc).AddTicks(4928),
                            Description = "Spacious and luxurious room",
                            Name = "Deluxe",
                            TotalAdult = 2,
                            TotalCapacity = 2,
                            TotalChild = 1,
                            UpdatedAt = new DateTime(2024, 5, 11, 4, 19, 27, 134, DateTimeKind.Utc).AddTicks(4929)
                        });
                });

            modelBuilder.Entity("HotelMS.Domain.Entities.Room", b =>
                {
                    b.HasOne("HotelMS.Domain.Entities.RoomCategory", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HotelMS.Domain.Entities.Hotel", "Hotel")
                        .WithMany()
                        .HasForeignKey("HotelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Hotel");
                });
#pragma warning restore 612, 618
        }
    }
}
