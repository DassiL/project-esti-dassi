﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Dal.Models;

public partial class LibraryContext : DbContext
{
    public LibraryContext(DbContextOptions<LibraryContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Adress> Adresses { get; set; }

    public virtual DbSet<Profession> Professions { get; set; }

    public virtual DbSet<ProfessionalsMan> ProfessionalsMen { get; set; }

    public virtual DbSet<Reference> References { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Adress>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tmp_ms_x__3214EC07EB40E955");

            entity.ToTable("Adress");

            entity.Property(e => e.Apartment)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("apartment");
            entity.Property(e => e.City)
                .IsRequired()
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("city");
            entity.Property(e => e.Street)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("street");
        });

        modelBuilder.Entity<Profession>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__professi__3214EC072B04D3D5");

            entity.ToTable("profession");

            entity.Property(e => e.Type)
                .IsRequired()
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("type");
        });

        modelBuilder.Entity<ProfessionalsMan>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Professi__3214EC0798ABE15A");

            entity.ToTable("ProfessionalsMan");

            entity.Property(e => e.Email)
                .IsRequired()
                .HasMaxLength(25)
                .HasColumnName("email");
            entity.Property(e => e.FirstName)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("first_name");
            entity.Property(e => e.HourlyPrice).HasColumnName("Hourly price");
            entity.Property(e => e.IdAdress).HasColumnName("id_adress");
            entity.Property(e => e.IdType).HasColumnName("id_type");
            entity.Property(e => e.LastName)
                .IsRequired()
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("last_name");
            entity.Property(e => e.Phon)
                .IsRequired()
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("phon");

            entity.HasOne(d => d.IdAdressNavigation).WithMany(p => p.ProfessionalsMen)
                .HasForeignKey(d => d.IdAdress)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProfessionalsMan_ToTable_Adress");

            entity.HasOne(d => d.IdTypeNavigation).WithMany(p => p.ProfessionalsMen)
                .HasForeignKey(d => d.IdType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProfessionalsMan_ToTableProfession");
        });

        modelBuilder.Entity<Reference>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__referenc__3214EC07B391B471");

            entity.ToTable("reference");

            entity.Property(e => e.Describe)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("describe");
            entity.Property(e => e.Eamail)
                .IsRequired()
                .HasMaxLength(25)
                .IsFixedLength()
                .HasColumnName("eamail");
            entity.Property(e => e.IdProfessionals).HasColumnName("id_Professionals");
            entity.Property(e => e.Phon)
                .IsRequired()
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("phon");
            entity.Property(e => e.Rating).HasColumnName("rating");

            entity.HasOne(d => d.IdProfessionalsNavigation).WithMany(p => p.References)
                .HasForeignKey(d => d.IdProfessionals)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_reference_ToTable");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}