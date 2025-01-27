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
    [Migration("20210515030037_Actualizacion SP de usuarios")]
    partial class ActualizacionSPdeusuarios
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

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            Id = new Guid("1d4c80ac-01fb-4697-bc3d-0c7d02840b4b"),
                            password = "juan123",
                            username = "Juan"
                        },
                        new
                        {
                            Id = new Guid("f135b57f-8648-41fc-b80b-e1701abef304"),
                            password = "lucrecia123",
                            username = "Lucrecia"
                        },
                        new
                        {
                            Id = new Guid("4eff11a8-5704-41b6-ae41-3f9662b3e316"),
                            password = "maria123",
                            username = "Maria"
                        },
                        new
                        {
                            Id = new Guid("fc2ac7da-9f87-44d4-b6cf-b424e5a66cba"),
                            password = "esteban123",
                            username = "Esteban"
                        },
                        new
                        {
                            Id = new Guid("cb3ca04d-ccbe-4ad4-aed6-0870071172ff"),
                            password = "pilar123",
                            username = "Pilar"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
