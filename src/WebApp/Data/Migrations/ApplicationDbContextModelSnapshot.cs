﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApp.Data.Context;

#nullable disable

namespace WebApp.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebApp.Domain.Customer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(125)
                        .HasColumnType("nvarchar(125)");

                    b.Property<DateTime>("RegistrationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 8, 5, 0, 23, 20, 314, DateTimeKind.Utc).AddTicks(345));

                    b.HasKey("Id");

                    b.ToTable("Customers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("de186d50-d218-4c81-9dbc-9dff0ff39946"),
                            Active = true,
                            DateOfBirth = new DateTime(2005, 8, 5, 0, 23, 20, 314, DateTimeKind.Utc).AddTicks(1599),
                            Email = "guilherme@hotmail.com",
                            Name = "Guilherme",
                            RegistrationDate = new DateTime(2020, 8, 5, 0, 23, 20, 314, DateTimeKind.Utc).AddTicks(1582)
                        },
                        new
                        {
                            Id = new Guid("2852c44e-2005-4145-87ad-02c4e6619129"),
                            Active = true,
                            DateOfBirth = new DateTime(2006, 8, 5, 0, 23, 20, 314, DateTimeKind.Utc).AddTicks(1653),
                            Email = "ana123@gmail.com",
                            Name = "Ana",
                            RegistrationDate = new DateTime(2021, 8, 5, 0, 23, 20, 314, DateTimeKind.Utc).AddTicks(1651)
                        },
                        new
                        {
                            Id = new Guid("7f20e568-3c03-4c02-8afb-0dcc6a5a2eed"),
                            Active = true,
                            DateOfBirth = new DateTime(2004, 8, 5, 0, 23, 20, 314, DateTimeKind.Utc).AddTicks(1658),
                            Email = "carlos45@yahoo.com",
                            Name = "Carlos",
                            RegistrationDate = new DateTime(2019, 8, 5, 0, 23, 20, 314, DateTimeKind.Utc).AddTicks(1657)
                        },
                        new
                        {
                            Id = new Guid("f89acce8-8235-40c6-b515-c29e213b8e30"),
                            Active = true,
                            DateOfBirth = new DateTime(2007, 8, 5, 0, 23, 20, 314, DateTimeKind.Utc).AddTicks(1665),
                            Email = "maria87@hotmail.com",
                            Name = "Maria",
                            RegistrationDate = new DateTime(2022, 8, 5, 0, 23, 20, 314, DateTimeKind.Utc).AddTicks(1663)
                        },
                        new
                        {
                            Id = new Guid("7f40737b-3b0c-4917-b04a-01a58fd37c92"),
                            Active = true,
                            DateOfBirth = new DateTime(2003, 8, 5, 0, 23, 20, 314, DateTimeKind.Utc).AddTicks(1670),
                            Email = "rafael.mtz@gmail.com",
                            Name = "Rafael",
                            RegistrationDate = new DateTime(2018, 8, 5, 0, 23, 20, 314, DateTimeKind.Utc).AddTicks(1668)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
