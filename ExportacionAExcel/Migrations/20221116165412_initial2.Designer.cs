﻿// <auto-generated />
using ExportacionAExcel.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ExportacionAExcel.Migrations
{
    [DbContext(typeof(ExcelContext))]
    [Migration("20221116165412_initial2")]
    partial class initial2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ExportacionAExcel.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pais")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Clientes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Apellido = "Lopez",
                            Direccion = "Pellegrini",
                            Email = "lopez@gmail.com",
                            Nombre = "Carlos",
                            Pais = "Argentina",
                            Telefono = "12345"
                        },
                        new
                        {
                            Id = 2,
                            Apellido = "Garcia",
                            Direccion = "Pellegrini",
                            Email = "garcia@gmail.com",
                            Nombre = "Julio",
                            Pais = "Argentina",
                            Telefono = "2312321135"
                        },
                        new
                        {
                            Id = 3,
                            Apellido = "Romero",
                            Direccion = "Belgrano",
                            Email = "romero@gmail.com",
                            Nombre = "Hugo",
                            Pais = "Argentina",
                            Telefono = "4421421124"
                        },
                        new
                        {
                            Id = 4,
                            Apellido = "Gimenez",
                            Direccion = "9 de julio",
                            Email = "gimenez@gmail.com",
                            Nombre = "Marcos",
                            Pais = "Argentina",
                            Telefono = "514314114"
                        },
                        new
                        {
                            Id = 5,
                            Apellido = "Messi",
                            Direccion = "25 de mayo",
                            Email = "messi@gmail.com",
                            Nombre = "Lionel",
                            Pais = "Argentina",
                            Telefono = "101001010"
                        },
                        new
                        {
                            Id = 6,
                            Apellido = "Gutierrez",
                            Direccion = "Hernandarias",
                            Email = "gutierrez@gmail.com",
                            Nombre = "Gael",
                            Pais = "Argentina",
                            Telefono = "23151111"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
