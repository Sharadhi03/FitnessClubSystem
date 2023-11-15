using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Fitnessclub.Data.Entities
{
    public partial class FMSContext : DbContext
    {
        public FMSContext()
        {
        }

        public FMSContext(DbContextOptions<FMSContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblMember> TblMembers { get; set; } = null!;
        public virtual DbSet<TblStaff> TblStaffs { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.;Database=FMS;Trusted_Connection=True;TrustServerCertificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblMember>(entity =>
            {
                entity.HasKey(e => e.MemberId);

                entity.ToTable("tblMember");

                entity.Property(e => e.MemberId).ValueGeneratedNever();

                entity.Property(e => e.DateOfBirth).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.MemberEmail)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MemberName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MemberPhone)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MemberType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.HasOne(d => d.Member)
                    .WithOne(p => p.TblMember)
                    .HasForeignKey<TblMember>(d => d.MemberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblMember_tblStaff");
            });

            modelBuilder.Entity<TblStaff>(entity =>
            {
                entity.HasKey(e => e.StaffId);

                entity.ToTable("tblStaff");

                entity.Property(e => e.StaffId).ValueGeneratedNever();

                entity.Property(e => e.DateOfBirth).HasColumnType("datetime");

                entity.Property(e => e.HireDate).HasColumnType("datetime");

                entity.Property(e => e.Position)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.StaffEmail)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StaffName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StaffPhone)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
