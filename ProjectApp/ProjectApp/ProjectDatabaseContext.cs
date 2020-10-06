using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ProjectModel
{
    public partial class ProjectDatabaseContext : DbContext
    {
        public ProjectDatabaseContext()
        {
        }

        public ProjectDatabaseContext(DbContextOptions<ProjectDatabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Days> Days { get; set; }
        public virtual DbSet<FamilyMembers> FamilyMembers { get; set; }
        public virtual DbSet<GetActivities> GetActivities { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ProjectDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Days>(entity =>
            {
                entity.HasKey(e => e.DayId);

                entity.HasIndex(e => e.ActivitiesId);

                entity.Property(e => e.Dayofweek)
                    .IsRequired()
                    .HasColumnName("_dayofweek")
                    .HasMaxLength(10);

            });

            modelBuilder.Entity<FamilyMembers>(entity =>
            {
                entity.HasKey(e => e.FamilyMemberId);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.LastName)
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.Occupation)
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Stage)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<GetActivities>(entity =>
            {
                entity.HasKey(e => e.ActivitiesId);

                entity.Property(e => e.Activity)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.ActivityDetails)
                    .HasMaxLength(50)
                    .IsFixedLength();
            });

            modelBuilder.Entity<LinkTable>(entity =>
            {
                entity.HasKey(e => e.LinkTableId);

                entity.HasIndex(e => e.ActivitiesId);
                entity.HasIndex(e => e.DayId);
                entity.HasIndex(e => e.FamilyMemberId);
            });
                OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
