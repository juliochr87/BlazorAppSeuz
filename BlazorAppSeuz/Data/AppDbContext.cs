using System;
using System.Collections.Generic;
using BlazorAppSeuz.Models;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;

namespace BlazorAppSeuz.Data;

public partial class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Tusuarios> Tusuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=127.0.0.1;port=3307;database=s4sistema;user=root;password=Admin12345", Microsoft.EntityFrameworkCore.ServerVersion.Parse("12.2.2-mariadb"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_uca1400_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Tusuarios>(entity =>
        {
            entity.HasKey(e => e.UsuavIdusuario).HasName("PRIMARY");

            entity
                .ToTable("tusuarios")
                .HasCharSet("latin1")
                .UseCollation("latin1_spanish_ci");

            entity.Property(e => e.UsuavIdusuario)
                .HasMaxLength(15)
                .HasColumnName("USUAV_IDUSUARIO");
            entity.Property(e => e.UsuanTipo)
                .HasDefaultValueSql("'1'")
                .HasComment("Tipo de usuario")
                .HasColumnType("int(10)")
                .HasColumnName("USUAN_TIPO");
            entity.Property(e => e.UsuavEmail)
                .HasMaxLength(150)
                .HasComment("Email")
                .HasColumnName("USUAV_EMAIL");
            entity.Property(e => e.UsuavId)
                .HasMaxLength(3)
                .HasComment("Id")
                .HasColumnName("USUAV_ID");
            entity.Property(e => e.UsuavIdperfil)
                .HasMaxLength(3)
                .HasColumnName("USUAV_IDPERFIL");
            entity.Property(e => e.UsuavMovil)
                .HasMaxLength(20)
                .HasComment("Movil")
                .HasColumnName("USUAV_MOVIL");
            entity.Property(e => e.UsuavNivelauto)
                .HasColumnType("int(10)")
                .HasColumnName("USUAV_NIVELAUTO");
            entity.Property(e => e.UsuavNombre)
                .HasMaxLength(45)
                .HasColumnName("USUAV_NOMBRE");
            entity.Property(e => e.UsuavPassword)
                .HasMaxLength(20)
                .HasColumnName("USUAV_PASSWORD");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
