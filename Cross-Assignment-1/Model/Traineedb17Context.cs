﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Model;

public partial class Traineedb17Context : DbContext
{
    public Traineedb17Context()
    {
    }

    public Traineedb17Context(DbContextOptions<Traineedb17Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Crossdemo> Crossdemos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=WIN-390Q81UT43Q\\SQLEXPRESS2017;Database=traineedb17;User Id=traineedb17;Password=hlmjXcsdRG7aPW63;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Crossdemo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Crossdem__3213E83FCD7AA07C");

            entity.ToTable("Crossdemo");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Sub)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("sub");
        });
        modelBuilder.HasSequence<int>("s1")
            .StartsAt(10L)
            .HasMin(1L)
            .HasMax(20L);

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
