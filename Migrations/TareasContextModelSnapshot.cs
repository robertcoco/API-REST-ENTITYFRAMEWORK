﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using projectEntity;

#nullable disable

namespace projectEntity.Migrations
{
    [DbContext(typeof(TareasContext))]
    partial class TareasContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("projectEntity.Models.Categoria", b =>
                {
                    b.Property<Guid>("categoriaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("Peso")
                        .HasColumnType("int");

                    b.HasKey("categoriaId");

                    b.ToTable("Categoria", (string)null);

                    b.HasData(
                        new
                        {
                            categoriaId = new Guid("89a4a2cb-0b25-4373-a558-066525e4334a"),
                            Descripcion = "Tareas de matematicas, lenguas espanola, ciencias sociales, ciencias naturales",
                            Nombre = "Tareas de la escuela",
                            Peso = 1
                        },
                        new
                        {
                            categoriaId = new Guid("2799307e-9ba5-4ee4-859c-e909339206d0"),
                            Descripcion = "Hacer ejercicios de piernas, brazos, hombros y espalda",
                            Nombre = "Hacer ejercicios",
                            Peso = 2
                        });
                });

            modelBuilder.Entity("projectEntity.Models.Tarea", b =>
                {
                    b.Property<Guid>("tareaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fechacreada")
                        .HasColumnType("datetime2");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<Guid>("categoriaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("prioridad")
                        .HasColumnType("int");

                    b.HasKey("tareaId");

                    b.HasIndex("categoriaId");

                    b.ToTable("Tarea", (string)null);

                    b.HasData(
                        new
                        {
                            tareaId = new Guid("dbfc07f7-bebf-4b66-a56f-5e7090f75511"),
                            Descripcion = "Tarea de ciencias naturales sobre el cuerpo humano",
                            Fechacreada = new DateTime(2022, 9, 22, 22, 50, 35, 267, DateTimeKind.Local).AddTicks(8822),
                            Titulo = "Hacer la tarea de ciencias naturales",
                            categoriaId = new Guid("89a4a2cb-0b25-4373-a558-066525e4334a"),
                            prioridad = 2
                        },
                        new
                        {
                            tareaId = new Guid("74a70252-5c9c-4f39-bb8c-058fe6f02ce0"),
                            Descripcion = "Ejercicios de piernas con pesas de 5kg, desplazamiento delantero y trasero",
                            Fechacreada = new DateTime(2022, 9, 22, 22, 50, 35, 267, DateTimeKind.Local).AddTicks(8957),
                            Titulo = "Ejercicios de piernas",
                            categoriaId = new Guid("2799307e-9ba5-4ee4-859c-e909339206d0"),
                            prioridad = 2
                        });
                });

            modelBuilder.Entity("projectEntity.Models.Tarea", b =>
                {
                    b.HasOne("projectEntity.Models.Categoria", "Categoria")
                        .WithMany("Tareas")
                        .HasForeignKey("categoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("projectEntity.Models.Categoria", b =>
                {
                    b.Navigation("Tareas");
                });
#pragma warning restore 612, 618
        }
    }
}
