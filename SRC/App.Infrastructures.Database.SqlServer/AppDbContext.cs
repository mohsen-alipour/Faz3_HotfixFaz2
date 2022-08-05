using System;
using System.Collections.Generic;
using App.Domain.Core.BaseData.Entity;
using App.Domain.Core.Customer.Entity;
using App.Domain.Core.Expert.Entity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace App.Infrastructures.Database.SqlServer
{
    public partial class AppDbContext : IdentityDbContext<AppUser, IdentityRole<int>, int>
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public virtual DbSet<Bid> Bids { get; set; } = null!;
        public virtual DbSet<Category> Categories { get; set; } = null!;
        public virtual DbSet<ExpertFavoriteCategory> ExpertFavoriteCategories { get; set; } = null!;
        public virtual DbSet<AppFile> Files { get; set; } = null!;
        public virtual DbSet<Order> Orders { get; set; } = null!;
        public virtual DbSet<OrderFile> OrderFiles { get; set; } = null!;
        public virtual DbSet<Service> Services { get; set; } = null!;
        public virtual DbSet<ServiceComment> ServiceComments { get; set; } = null!;
        public virtual DbSet<ServiceFile> ServiceFiles { get; set; } = null!;
        public virtual DbSet<Status> Statuses { get; set; } = null!;

  

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Bid>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasPrecision(0);

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.Bids)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Bids_Order");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("Category");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Title)
                    .HasMaxLength(250)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ExpertFavoriteCategory>(entity =>
            {
                entity.ToTable("ExpertFavoriteCategory");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasPrecision(0);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.ExpertFavoriteCategories)
                    .HasForeignKey(d => d.Categoryid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExpertFavoriteCategory_Category");
            });

            modelBuilder.Entity<AppFile>(entity =>
            {
                entity.ToTable("File");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasPrecision(0);

                entity.Property(e => e.FileAddress)
                    .HasMaxLength(500)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("Order");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasPrecision(0);

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.Serviceid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_Service");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_Status");
            });

            modelBuilder.Entity<OrderFile>(entity =>
            {
                entity.ToTable("OrderFile");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasPrecision(0);

                entity.HasOne(d => d.File)
                    .WithMany(p => p.OrderFiles)
                    .HasForeignKey(d => d.FileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderFile_File");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderFiles)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderFile_Order");
            });

            modelBuilder.Entity<Service>(entity =>
            {
                entity.ToTable("Service");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ShortDescription)
                    .HasMaxLength(1000)
                    .IsFixedLength();

                entity.Property(e => e.Title)
                    .HasMaxLength(250)
                    .IsFixedLength();

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Services)
                    .HasForeignKey(d => d.Categoryid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Service_Category");
            });

            modelBuilder.Entity<ServiceComment>(entity =>
            {
                entity.ToTable("ServiceComment");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CommentText)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.CreatedAt).HasPrecision(0);

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.ServiceComments)
                    .HasForeignKey(d => d.ServiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServiceComment_Service");
            });

            modelBuilder.Entity<ServiceFile>(entity =>
            {
                entity.ToTable("ServiceFile");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasPrecision(0);

                entity.HasOne(d => d.File)
                    .WithMany(p => p.ServiceFiles)
                    .HasForeignKey(d => d.FileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServiceFile_File");

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.ServiceFiles)
                    .HasForeignKey(d => d.ServiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServiceFile_Service");
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.ToTable("Status");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Title)
                    .HasMaxLength(250)
                    .IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
