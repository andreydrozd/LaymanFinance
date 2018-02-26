using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace LaymanFinance.Models
{
    public partial class AndreyTestContext : Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityDbContext<ApplicationUser>
    {

        public AndreyTestContext() : base()
        {

        }

        public AndreyTestContext(DbContextOptions options) : base(options)
        {

        }

        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Inflow> Inflow { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<Outlay> Outlay { get; set; }
        public virtual DbSet<Promo> Promo { get; set; }
        public virtual DbSet<Service> Service { get; set; }
        public virtual DbSet<ServiceDetail> ServiceDetail { get; set; }
        public virtual DbSet<Testimonial> Testimonial { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Inflow>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.DateEntered)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateOccurred).HasColumnType("date");

                entity.Property(e => e.Memo).HasMaxLength(160);

                entity.Property(e => e.Payor)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Inflow)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Inflow_Category");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Total).HasColumnType("money");
            });

            modelBuilder.Entity<Outlay>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.DateEntered)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateOccurred).HasColumnType("date");

                entity.Property(e => e.Memo).HasMaxLength(160);

                entity.Property(e => e.Payee)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Outlay)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Outlay_Category");
            });

            modelBuilder.Entity<Promo>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.PercentageOff).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<Service>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DescriptionOne)
                    .IsRequired()
                    .HasMaxLength(160);

                entity.Property(e => e.DescriptionThree).HasMaxLength(160);

                entity.Property(e => e.DescriptionTwo).HasMaxLength(160);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Price).HasColumnType("money");
            });

            modelBuilder.Entity<ServiceDetail>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BeginDate).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.PromoId).HasColumnName("PromoID");

                entity.Property(e => e.ServiceId).HasColumnName("ServiceID");

                entity.HasOne(d => d.Promo)
                    .WithMany(p => p.ServiceDetail)
                    .HasForeignKey(d => d.PromoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServiceDetail_Promo");

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.ServiceDetail)
                    .HasForeignKey(d => d.ServiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServiceDetail_Service");
            });

            modelBuilder.Entity<Testimonial>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ImageUrl)
                    .IsRequired()
                    .HasColumnName("ImageURL")
                    .HasMaxLength(100);

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ServiceId).HasColumnName("ServiceID");

                entity.Property(e => e.TextOne)
                    .IsRequired()
                    .HasMaxLength(160);

                entity.Property(e => e.TextThree).HasMaxLength(160);

                entity.Property(e => e.TextTwo).HasMaxLength(160);

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.Testimonial)
                    .HasForeignKey(d => d.ServiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Testimonial_Service");
            });
        }
    }
}
