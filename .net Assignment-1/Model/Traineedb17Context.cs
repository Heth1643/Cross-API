using System;
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

    public virtual DbSet<Department1> Department1s { get; set; }

    public virtual DbSet<Employee1> Employee1s { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=WIN-390Q81UT43Q\\SQLEXPRESS2017;Database=traineedb17;User Id=traineedb17;Password=hlmjXcsdRG7aPW63;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Department1>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__departme__3214EC07B7F53790");

            entity.ToTable("department1");

            entity.Property(e => e.DeptName)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Employee1>(entity =>
        {
            entity.HasKey(e => e.EmpId).HasName("PK__Employee__AF2DBB99E8A002F4");

            entity.ToTable("Employee1");

            entity.Property(e => e.EmpName)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.Dept).WithMany(p => p.Employee1s)
                .HasForeignKey(d => d.DeptId)
                .HasConstraintName("FK__Employee1__DeptI__70A8B9AE");
        });
        modelBuilder.HasSequence<int>("s1")
            .StartsAt(10L)
            .HasMin(1L)
            .HasMax(20L);

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
