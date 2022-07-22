﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OSPeConTI.Auth.Services.Infrastructure;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(AuthContext))]
    partial class AuthContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("OSPeConTI.Auth.Services.Domain.Entities.AuthData", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Activo")
                        .HasColumnType("bit");

                    b.Property<string>("CodigoRecupero")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaAlta")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaUpdate")
                        .HasColumnType("datetime2");

                    b.Property<int>("LegacyId")
                        .HasColumnType("int");

                    b.Property<string>("Origen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Salt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UsuarioAlta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("UsuarioProfileId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UsuarioUpdate")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioProfileId")
                        .IsUnique()
                        .HasFilter("[UsuarioProfileId] IS NOT NULL");

                    b.ToTable("AuthData", "dbo");
                });

            modelBuilder.Entity("OSPeConTI.Auth.Services.Domain.Entities.UsuarioProfile", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Activo")
                        .HasColumnType("bit");

                    b.Property<string>("Apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaAlta")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaUpdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Imagen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LegacyId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreUsuario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UsuarioAlta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UsuarioUpdate")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UsuarioProfile", "dbo");
                });

            modelBuilder.Entity("OSPeConTI.Auth.Services.Domain.Entities.AuthData", b =>
                {
                    b.HasOne("OSPeConTI.Auth.Services.Domain.Entities.UsuarioProfile", null)
                        .WithOne("AuthData")
                        .HasForeignKey("OSPeConTI.Auth.Services.Domain.Entities.AuthData", "UsuarioProfileId");
                });

            modelBuilder.Entity("OSPeConTI.Auth.Services.Domain.Entities.UsuarioProfile", b =>
                {
                    b.Navigation("AuthData");
                });
#pragma warning restore 612, 618
        }
    }
}
