﻿// <auto-generated />
using System;
using Imobiliaria.API.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Imobiliaria.API.Migrations
{
    [DbContext(typeof(ImobiliariaContext))]
    [Migration("20220515214148_Cliente")]
    partial class Cliente
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Imobiliaria.API.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2")
                        .HasColumnName("dataNascimento");

                    b.Property<int>("ImovelId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("nome");

                    b.Property<string>("Sobrenome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("sobrenome");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("status");

                    b.HasKey("Id");

                    b.HasIndex("ImovelId");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Imobiliaria.API.Models.Imovel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("DescricaoCurta")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("descricaoCurta");

                    b.Property<string>("DescricaoLonga")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("descricaoLonga");

                    b.Property<int>("Tipo")
                        .HasColumnType("int")
                        .HasColumnName("tipo");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("titulo");

                    b.Property<double>("Valor")
                        .HasColumnType("float")
                        .HasColumnName("valor");

                    b.HasKey("Id");

                    b.ToTable("Imoveis");
                });

            modelBuilder.Entity("Imobiliaria.API.Models.Cliente", b =>
                {
                    b.HasOne("Imobiliaria.API.Models.Imovel", "Imovel")
                        .WithMany()
                        .HasForeignKey("ImovelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Imovel");
                });
#pragma warning restore 612, 618
        }
    }
}