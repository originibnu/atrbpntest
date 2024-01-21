using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Testatrbpn1.Models;

public partial class PlaceContext : DbContext
{
    public PlaceContext()
    {
    }

    public PlaceContext(DbContextOptions<PlaceContext> options)
        : base(options)
    {
    }

    public virtual DbSet<LokasiPesertum> LokasiPeserta { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Database=place;Username=postgres;Password=admin");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<LokasiPesertum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("lokasi_peserta_pkey");

            entity.ToTable("lokasi_peserta");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AlamatPeserta)
                .HasMaxLength(100)
                .HasColumnName("alamat_peserta");
            entity.Property(e => e.NamaPeserta)
                .HasMaxLength(100)
                .HasColumnName("nama_peserta");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
