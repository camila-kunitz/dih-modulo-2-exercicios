using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ClinicaVeterinaria.Models;

namespace ClinicaVeterinaria.Context
{
    public partial class ClinicaVeterinariaContext : DbContext
    {
        public ClinicaVeterinariaContext()
        {
        }

        public ClinicaVeterinariaContext(DbContextOptions<ClinicaVeterinariaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Animal> Animals { get; set; } = null!;
        public virtual DbSet<Cliente> Clientes { get; set; } = null!;
        public virtual DbSet<Consultum> Consulta { get; set; } = null!;
        public virtual DbSet<Especie> Especies { get; set; } = null!;
        public virtual DbSet<Exame> Exames { get; set; } = null!;
        public virtual DbSet<Tratamento> Tratamentos { get; set; } = null!;
        public virtual DbSet<Veterinario> Veterinarios { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-H5FNF7M\\SQLEXPRESS;Database=ClinicaVeterinaria;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Animal>(entity =>
            {
                entity.ToTable("Animal");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdCliente).HasColumnName("idCliente");

                entity.Property(e => e.IdEspecie).HasColumnName("idEspecie");

                entity.Property(e => e.Idade).HasColumnName("idade");

                entity.Property(e => e.Nome)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nome");

                entity.Property(e => e.Sexo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("sexo");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.Animals)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cliente_Animal");

                entity.HasOne(d => d.IdEspecieNavigation)
                    .WithMany(p => p.Animals)
                    .HasForeignKey(d => d.IdEspecie)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Especie_Animal");
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.ToTable("Cliente");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Bairro)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("bairro");

                entity.Property(e => e.Cep)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("cep");

                entity.Property(e => e.Cidade)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("cidade");

                entity.Property(e => e.Endereco)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("endereco");

                entity.Property(e => e.Estado)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("estado")
                    .IsFixedLength();

                entity.Property(e => e.Nome)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nome");

                entity.Property(e => e.Telefone)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("telefone");
            });

            modelBuilder.Entity<Consultum>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Data)
                    .HasColumnType("datetime")
                    .HasColumnName("data");

                entity.Property(e => e.Historico)
                    .IsUnicode(false)
                    .HasColumnName("historico");

                entity.Property(e => e.IdTratamento).HasColumnName("idTratamento");

                entity.Property(e => e.IdVeterinario).HasColumnName("idVeterinario");

                entity.HasOne(d => d.IdTratamentoNavigation)
                    .WithMany(p => p.Consulta)
                    .HasForeignKey(d => d.IdTratamento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tratamento_Consulta");

                entity.HasOne(d => d.IdVeterinarioNavigation)
                    .WithMany(p => p.Consulta)
                    .HasForeignKey(d => d.IdVeterinario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Veterinario_Consulta");
            });

            modelBuilder.Entity<Especie>(entity =>
            {
                entity.ToTable("Especie");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("descricao");
            });

            modelBuilder.Entity<Exame>(entity =>
            {
                entity.ToTable("Exame");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("descricao");

                entity.Property(e => e.IdConsulta).HasColumnName("idConsulta");

                entity.HasOne(d => d.IdConsultaNavigation)
                    .WithMany(p => p.Exames)
                    .HasForeignKey(d => d.IdConsulta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Consulta_Exame");
            });

            modelBuilder.Entity<Tratamento>(entity =>
            {
                entity.ToTable("Tratamento");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DataFinal)
                    .HasColumnType("datetime")
                    .HasColumnName("dataFinal");

                entity.Property(e => e.DataInicial)
                    .HasColumnType("datetime")
                    .HasColumnName("dataInicial");

                entity.Property(e => e.IdAnimal).HasColumnName("idAnimal");

                entity.HasOne(d => d.IdAnimalNavigation)
                    .WithMany(p => p.Tratamentos)
                    .HasForeignKey(d => d.IdAnimal)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Especie_Tratamento");
            });

            modelBuilder.Entity<Veterinario>(entity =>
            {
                entity.ToTable("Veterinario");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Endereco)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("endereco");

                entity.Property(e => e.Nome)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nome");

                entity.Property(e => e.Telefone)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("telefone");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
