using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SaboresByMali.Models;

public partial class SaboresByMaliContext : DbContext
{
    public SaboresByMaliContext()
    {
    }

    public SaboresByMaliContext(DbContextOptions<SaboresByMaliContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=IAMVILLALONA\\IAMVILLALONA; Database=SaboresByMali; Trusted_Connection=True; Encrypt = False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__USUARIO__3214EC275AB58108");

            entity.ToTable("USUARIO");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Clave)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("CLAVE");
            entity.Property(e => e.Nombre)
                .HasMaxLength(55)
                .IsUnicode(false)
                .HasColumnName("NOMBRE");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
