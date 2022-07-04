﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OSPeConTI.BackEndBase.Services.CatalogoMateriales.Infrastructure;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(CatalogoMaterialesContext))]
    [Migration("20220628143253_PrimeraMigracionLog")]
    partial class PrimeraMigracionLog
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("OSPeConTI.BackEndBase.Services.CatalogoMateriales.Domain.Entities.Clasificacion", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Activo")
                        .HasColumnType("bit");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaAlta")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaUpdate")
                        .HasColumnType("datetime2");

                    b.Property<int>("LegacyId")
                        .HasColumnType("int");

                    b.Property<string>("UsuarioAlta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UsuarioUpdate")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Clasificaciones", "dbo");
                });

            modelBuilder.Entity("OSPeConTI.BackEndBase.Services.CatalogoMateriales.Domain.Entities.Material", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Activo")
                        .HasColumnType("bit");

                    b.Property<Guid?>("ClasificacionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Codigo")
                        .HasColumnType("int");

                    b.Property<decimal>("Costo")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaAlta")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaUpdate")
                        .HasColumnType("datetime2");

                    b.Property<int>("LegacyId")
                        .HasColumnType("int");

                    b.Property<Guid?>("TipoMaterialId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UsuarioAlta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UsuarioUpdate")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ClasificacionId");

                    b.HasIndex("TipoMaterialId");

                    b.ToTable("Materiales", "dbo");
                });

            modelBuilder.Entity("OSPeConTI.BackEndBase.Services.CatalogoMateriales.Domain.Entities.TipoMaterial", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Activo")
                        .HasColumnType("bit");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaAlta")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaUpdate")
                        .HasColumnType("datetime2");

                    b.Property<int>("LegacyId")
                        .HasColumnType("int");

                    b.Property<string>("UsuarioAlta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UsuarioUpdate")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TipoMateriales", "dbo");
                });

            modelBuilder.Entity("OSPeConTI.BackEndBase.Services.CatalogoMateriales.Domain.Entities.Material", b =>
                {
                    b.HasOne("OSPeConTI.BackEndBase.Services.CatalogoMateriales.Domain.Entities.Clasificacion", "Clasificacion")
                        .WithMany("Materiales")
                        .HasForeignKey("ClasificacionId");

                    b.HasOne("OSPeConTI.BackEndBase.Services.CatalogoMateriales.Domain.Entities.TipoMaterial", "TipoMaterial")
                        .WithMany("Materiales")
                        .HasForeignKey("TipoMaterialId");

                    b.Navigation("Clasificacion");

                    b.Navigation("TipoMaterial");
                });

            modelBuilder.Entity("OSPeConTI.BackEndBase.Services.CatalogoMateriales.Domain.Entities.Clasificacion", b =>
                {
                    b.Navigation("Materiales");
                });

            modelBuilder.Entity("OSPeConTI.BackEndBase.Services.CatalogoMateriales.Domain.Entities.TipoMaterial", b =>
                {
                    b.Navigation("Materiales");
                });
#pragma warning restore 612, 618
        }
    }
}
