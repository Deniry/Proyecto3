using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Diagnosticos.Models;

public partial class DBDiagnosticosContext : DbContext
{
    public DBDiagnosticosContext()
    {
    }

    public DBDiagnosticosContext(DbContextOptions<DBDiagnosticosContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cuidado> Cuidados { get; set; }

    public virtual DbSet<Enfermedade> Enfermedades { get; set; }

    public virtual DbSet<Grupo> Grupos { get; set; }

    public virtual DbSet<Sintomascac> Sintomascacs { get; set; }

    public virtual DbSet<Sintomassucu> Sintomassucus { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=BD_DIAGNOSTICOS;Trusted_Connection=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cuidado>(entity =>
        {
            entity.HasKey(e => e.CuidadosId).HasName("CUIDADOS_PK");

            entity.ToTable("CUIDADOS");

            entity.Property(e => e.CuidadosId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Descripcion).IsUnicode(false);

            entity.HasOne(d => d.Enfermedad).WithMany(p => p.Cuidados)
                .HasForeignKey(d => d.EnfermedadId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("CUIDADOS_FK0");
        });

        modelBuilder.Entity<Enfermedade>(entity =>
        {
            entity.HasKey(e => e.EnfermedadId).HasName("ENFERMEDADES_PK");

            entity.ToTable("ENFERMEDADES");

            entity.Property(e => e.EnfermedadId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Descripcion).IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Grupo>(entity =>
        {
            entity.HasKey(e => e.GrupoId).HasName("GRUPO_PK");

            entity.ToTable("GRUPO");

            entity.Property(e => e.GrupoId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Descripcion).IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Sintomascac>(entity =>
        {
            entity.HasKey(e => e.SintomaCacId).HasName("SINTOMASCAC_PK");

            entity.ToTable("SINTOMASCAC");

            entity.Property(e => e.SintomaCacId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Descripcion).IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.HasOne(d => d.Enfermedad).WithMany(p => p.Sintomascacs)
                .HasForeignKey(d => d.EnfermedadId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("SINTOMASCAC_FK0");

            entity.HasOne(d => d.Grupo).WithMany(p => p.Sintomascacs)
                .HasForeignKey(d => d.GrupoId)
                .HasConstraintName("SINTOMASCAC_FK1");
        });

        modelBuilder.Entity<Sintomassucu>(entity =>
        {
            entity.HasKey(e => e.SintomaSucuId).HasName("SINTOMASSUCU_PK");

            entity.ToTable("SINTOMASSUCU");

            entity.Property(e => e.SintomaSucuId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Descripcion).IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.HasOne(d => d.Enfermedad).WithMany(p => p.Sintomassucus)
                .HasForeignKey(d => d.EnfermedadId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("SINTOMASSUCU_FK0");

            entity.HasOne(d => d.Grupo).WithMany(p => p.Sintomassucus)
                .HasForeignKey(d => d.GrupoId)
                .HasConstraintName("SINTOMASSUCU_FK1");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
