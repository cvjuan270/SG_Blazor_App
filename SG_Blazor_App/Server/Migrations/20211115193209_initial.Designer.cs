﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SG_Blazor_App.Server.Data;

#nullable disable

namespace SG_Blazor_App.Server.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20211115193209_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SG_Blazor_App.Shared.Models.AtencionModel", b =>
                {
                    b.Property<int>("IdAtenciones")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdAtenciones"), 1L, 1);

                    b.Property<int?>("AlEnHc")
                        .HasColumnType("int");

                    b.Property<int?>("AleAud")
                        .HasColumnType("int");

                    b.Property<int?>("AleEnf")
                        .HasColumnType("int");

                    b.Property<int?>("AleMed")
                        .HasColumnType("int");

                    b.Property<string>("Area")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("DocIde")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Empres")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("FecAte")
                        .HasColumnType("date");

                    b.Property<TimeSpan?>("Hora")
                        .HasColumnType("time");

                    b.Property<string>("Local0")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("NomApe")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PeReAd")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Perfil")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Proyec")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PueTra")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("SubCon")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("TipExa")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("IdAtenciones")
                        .HasName("PK_dbo.Atenciones");

                    b.ToTable("Atenciones");
                });

            modelBuilder.Entity("SG_Blazor_App.Shared.Models.ConAte.AdmisionModel", b =>
                {
                    b.Property<int>("IdAdmi")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdAdmi"), 1L, 1);

                    b.Property<bool>("EnvApt")
                        .HasColumnType("bit");

                    b.Property<bool>("EnvAsi")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("FecEnvResEmp")
                        .HasColumnType("date");

                    b.Property<DateTime?>("FecEnvResMed")
                        .HasColumnType("date");

                    b.Property<DateTime?>("HorIng")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("HorReg")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("HorSal")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdAtenciones")
                        .HasColumnType("int");

                    b.Property<string>("Pendie")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("IdAdmi");

                    b.HasIndex("IdAtenciones");

                    b.ToTable("admisions");
                });

            modelBuilder.Entity("SG_Blazor_App.Shared.Models.ConAte.InterconsultaModel", b =>
                {
                    b.Property<int>("IdInter")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdInter"), 1L, 1);

                    b.Property<string>("Descri")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("EnHoIn")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("FeCoPa")
                        .HasColumnType("date");

                    b.Property<DateTime?>("FeLeObs")
                        .HasColumnType("date");

                    b.Property<DateTime?>("FecEnv")
                        .HasColumnType("date");

                    b.Property<int>("IdAtenciones")
                        .HasColumnType("int");

                    b.Property<string>("PeCoPa")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PeEnCo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("IdInter");

                    b.HasIndex("IdAtenciones");

                    b.ToTable("interconsultas");
                });

            modelBuilder.Entity("SG_Blazor_App.Shared.Models.EspecialidadMedicaModel", b =>
                {
                    b.Property<int>("IdEspeMedic")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdEspeMedic"), 1L, 1);

                    b.Property<string>("Especialidad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdEspeMedic");

                    b.ToTable("especialidadMedica");
                });

            modelBuilder.Entity("SG_Blazor_App.Shared.Models.ConAte.AdmisionModel", b =>
                {
                    b.HasOne("SG_Blazor_App.Shared.Models.AtencionModel", "atencion")
                        .WithMany()
                        .HasForeignKey("IdAtenciones")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("atencion");
                });

            modelBuilder.Entity("SG_Blazor_App.Shared.Models.ConAte.InterconsultaModel", b =>
                {
                    b.HasOne("SG_Blazor_App.Shared.Models.AtencionModel", null)
                        .WithMany("interconsultas")
                        .HasForeignKey("IdAtenciones")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SG_Blazor_App.Shared.Models.AtencionModel", b =>
                {
                    b.Navigation("interconsultas");
                });
#pragma warning restore 612, 618
        }
    }
}
