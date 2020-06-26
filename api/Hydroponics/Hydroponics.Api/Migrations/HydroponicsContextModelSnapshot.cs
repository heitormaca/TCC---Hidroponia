﻿// <auto-generated />
using System;
using Hydroponics.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Hydroponics.Migrations
{
    [DbContext(typeof(HydroponicsContext))]
    partial class HydroponicsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Hydroponics.Models.Bancada", b =>
                {
                    b.Property<int>("IdBancada")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id_bancada")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataFim")
                        .HasColumnName("dataFim")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("DataInicio")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("dataInicio")
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<int?>("IdEstufa")
                        .HasColumnName("id_estufa")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnName("nome")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Semeio")
                        .IsRequired()
                        .HasColumnName("semeio")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<double>("SensorEcMax")
                        .HasColumnName("sensorEcMax")
                        .HasColumnType("float");

                    b.Property<double>("SensorEcMin")
                        .HasColumnName("sensorEcMin")
                        .HasColumnType("float");

                    b.Property<double>("SensorPhMax")
                        .HasColumnName("sensorPhMax")
                        .HasColumnType("float");

                    b.Property<double>("SensorPhMin")
                        .HasColumnName("sensorPhMin")
                        .HasColumnType("float");

                    b.Property<double>("SensorTempBancMax")
                        .HasColumnName("sensorTempBancMax")
                        .HasColumnType("float");

                    b.Property<double>("SensorTempBancMin")
                        .HasColumnName("sensorTempBancMin")
                        .HasColumnType("float");

                    b.Property<double>("SensorTempSolMax")
                        .HasColumnName("sensorTempSolMax")
                        .HasColumnType("float");

                    b.Property<double>("SensorTempSolMin")
                        .HasColumnName("sensorTempSolMin")
                        .HasColumnType("float");

                    b.Property<bool?>("StatusBancada")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("statusBancada")
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((1))");

                    b.HasKey("IdBancada")
                        .HasName("PK__Bancada__028BFB5B9CDA8DBC");

                    b.HasIndex("IdEstufa");

                    b.ToTable("Bancada");
                });

            modelBuilder.Entity("Hydroponics.Models.BancadaSensores", b =>
                {
                    b.Property<int>("IdBancadaSensores")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id_bancadaSensores")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DataAtual")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("dataAtual")
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<int?>("IdBancada")
                        .HasColumnName("id_bancada")
                        .HasColumnType("int");

                    b.Property<double>("SensorEc")
                        .HasColumnName("sensorEc")
                        .HasColumnType("float");

                    b.Property<double>("SensorPh")
                        .HasColumnName("sensorPh")
                        .HasColumnType("float");

                    b.Property<double>("SensorTempBanc")
                        .HasColumnName("sensorTempBanc")
                        .HasColumnType("float");

                    b.Property<double>("SensorTempSol")
                        .HasColumnName("sensorTempSol")
                        .HasColumnType("float");

                    b.HasKey("IdBancadaSensores")
                        .HasName("PK__BancadaS__609AC5D6682B5785");

                    b.HasIndex("IdBancada");

                    b.ToTable("BancadaSensores");
                });

            modelBuilder.Entity("Hydroponics.Models.Estufa", b =>
                {
                    b.Property<int>("IdEstufa")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id_estufa")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DataInicio")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("dataInicio")
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnName("nome")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("IdEstufa")
                        .HasName("PK__Estufa__58AD6956DDA5CB1C");

                    b.ToTable("Estufa");
                });

            modelBuilder.Entity("Hydroponics.Models.Usuario", b =>
                {
                    b.Property<int>("IdUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id_usuario")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnName("email")
                        .HasColumnType("varchar(70)")
                        .HasMaxLength(70)
                        .IsUnicode(false);

                    b.Property<string>("Imagem")
                        .HasColumnName("imagem")
                        .HasColumnType("text");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnName("nome")
                        .HasColumnType("varchar(70)")
                        .HasMaxLength(70)
                        .IsUnicode(false);

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnName("senha")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.HasKey("IdUsuario")
                        .HasName("PK__Usuario__4E3E04AD3CF9B712");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("Hydroponics.Models.Bancada", b =>
                {
                    b.HasOne("Hydroponics.Models.Estufa", "IdEstufaNavigation")
                        .WithMany("Bancada")
                        .HasForeignKey("IdEstufa")
                        .HasConstraintName("FK__Bancada__id_estu__5070F446");
                });

            modelBuilder.Entity("Hydroponics.Models.BancadaSensores", b =>
                {
                    b.HasOne("Hydroponics.Models.Bancada", "IdBancadaNavigation")
                        .WithMany("BancadaSensores")
                        .HasForeignKey("IdBancada")
                        .HasConstraintName("FK__BancadaSe__id_ba__5441852A");
                });
#pragma warning restore 612, 618
        }
    }
}
