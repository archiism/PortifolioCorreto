﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PortifolioCorreto.Data;

namespace PortifolioCorreto.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210613222758_logsandupdateprojeto")]
    partial class logsandupdateprojeto
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.7");

            modelBuilder.Entity("PortifolioCorreto.Data.Login", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("email")
                        .HasColumnType("longtext");

                    b.Property<string>("senha")
                        .HasColumnType("longtext");

                    b.Property<string>("usuario")
                        .HasColumnType("longtext");

                    b.HasKey("id");

                    b.ToTable("Login");

                    b.HasData(
                        new
                        {
                            id = 1,
                            email = "netomelosantana@gmail.com",
                            senha = "2447679Site",
                            usuario = "archiism"
                        });
                });

            modelBuilder.Entity("PortifolioCorreto.Data.Logs", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("usuario")
                        .HasColumnType("longtext");

                    b.HasKey("id");

                    b.ToTable("Logs");
                });

            modelBuilder.Entity("PortifolioCorreto.Data.Projetos", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("data")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("descricao")
                        .HasColumnType("longtext");

                    b.Property<string>("nome")
                        .HasColumnType("longtext");

                    b.HasKey("id");

                    b.ToTable("Projetos");
                });
#pragma warning restore 612, 618
        }
    }
}
