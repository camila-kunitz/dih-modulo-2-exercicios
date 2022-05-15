using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Loja.API.Models;

namespace Loja.API.Context
{
    public partial class LojaContext : DbContext
    {
        public LojaContext()
        {
        }

        public LojaContext(DbContextOptions<LojaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Fabricante> Fabricantes { get; set; } = null!;
        public virtual DbSet<Produto> Produtos { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=Loja;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Fabricante>(entity =>
            {
                entity.ToTable("Fabricante");

                entity.Property(e => e.Cnpj)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CNPJ");

                entity.Property(e => e.RazaoSocial)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Produto>(entity =>
            {
                entity.ToTable("Produto");

                entity.HasIndex(e => e.IdFabricante, "UQ__Produto__1F4C254B9DB87514")
                    .IsUnique();

                entity.Property(e => e.Descricao)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Preco).HasColumnType("money");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdFabricanteNavigation)
                    .WithOne(p => p.Produto)
                    .HasForeignKey<Produto>(d => d.IdFabricante)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Produto_Fabricante");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
