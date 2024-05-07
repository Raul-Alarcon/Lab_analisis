﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using adsProyecto.DB;

#nullable disable

namespace adsProyecto.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240507214643_Grupos")]
    partial class Grupos
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("adsProyecto.Models.Carrera", b =>
                {
                    b.Property<int>("IdCarrera")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCarrera"));

                    b.Property<string>("CodigoCarrera")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.Property<string>("NombreCarrera")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IdCarrera");

                    b.ToTable("Carreras");
                });

            modelBuilder.Entity("adsProyecto.Models.Estudiante", b =>
                {
                    b.Property<int>("IdEstudiante")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdEstudiante"));

                    b.Property<string>("ApellidoEstudiante")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CodigoEstudiante")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CorreoEstudiante")
                        .IsRequired()
                        .HasMaxLength(254)
                        .HasColumnType("nvarchar(254)");

                    b.Property<string>("NombreEstudiante")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IdEstudiante");

                    b.ToTable("Estudiantes");
                });

            modelBuilder.Entity("adsProyecto.Models.Grupo", b =>
                {
                    b.Property<int>("IdGrupo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdGrupo"));

                    b.Property<int>("IdCarrera")
                        .HasColumnType("int");

                    b.Property<int>("IdMateria")
                        .HasColumnType("int");

                    b.Property<int>("IdProfesor")
                        .HasColumnType("int");

                    b.Property<string>("anio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cliclo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdGrupo");

                    b.ToTable("Grupos");
                });
#pragma warning restore 612, 618
        }
    }
}
