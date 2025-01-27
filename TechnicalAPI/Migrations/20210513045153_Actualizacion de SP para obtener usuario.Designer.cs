﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Support.Persistence.Contexts;

namespace TechnicalAPI.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20210513045153_Actualizacion de SP para obtener usuario")]
    partial class ActualizaciondeSPparaobtenerusuario
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Support.Domain.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            Id = new Guid("05cf8e9e-4ba4-4dcc-81dc-75796e90d56f"),
                            email = "juan@juan.com",
                            username = "Juan"
                        },
                        new
                        {
                            Id = new Guid("0c3a7b5f-2374-4976-848d-a5a48846972b"),
                            email = "lucrecia@lucrecia.com",
                            username = "Lucrecia"
                        },
                        new
                        {
                            Id = new Guid("cdee308a-5be9-4200-b29e-71307b4154dd"),
                            email = "maria@maria.com",
                            username = "Maria"
                        },
                        new
                        {
                            Id = new Guid("922f4cdf-709e-404d-84d5-68e6364a4030"),
                            email = "esteban@esteban.com",
                            username = "Esteban"
                        },
                        new
                        {
                            Id = new Guid("b544912d-dbe5-4689-8dd2-bd9856df59f7"),
                            email = "pilar@pilar.com",
                            username = "Pilar"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
