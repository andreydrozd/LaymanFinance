﻿// <auto-generated />
using LaymanFinance.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace LaymanFinance.Migrations.AndreyTest
{
    [DbContext(typeof(AndreyTestContext))]
    partial class AndreyTestContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LaymanFinance.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FavoriteColor");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("LaymanFinance.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("BudgetedAmount");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("LaymanFinance.Models.Inflow", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID");

                    b.Property<decimal>("Amount")
                        .HasColumnType("money");

                    b.Property<int>("CategoryId")
                        .HasColumnName("CategoryID");

                    b.Property<DateTime>("DateEntered")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<DateTime?>("DateModified")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<DateTime>("DateOccurred")
                        .HasColumnType("date");

                    b.Property<string>("Memo")
                        .HasMaxLength(160);

                    b.Property<string>("Payor")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Inflow");
                });

            modelBuilder.Entity("LaymanFinance.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID");

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<DateTime?>("DateModified")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<int?>("PromoId");

                    b.Property<decimal>("SubTotal");

                    b.Property<decimal>("Total")
                        .HasColumnType("money");

                    b.HasKey("Id");

                    b.HasIndex("PromoId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("LaymanFinance.Models.Outlay", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID");

                    b.Property<decimal>("Amount")
                        .HasColumnType("money");

                    b.Property<int>("CategoryId")
                        .HasColumnName("CategoryID");

                    b.Property<DateTime>("DateEntered")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<DateTime?>("DateModified")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<DateTime>("DateOccurred")
                        .HasColumnType("date");

                    b.Property<string>("Memo")
                        .IsRequired()
                        .HasMaxLength(160);

                    b.Property<string>("Payee")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Outlay");
                });

            modelBuilder.Entity("LaymanFinance.Models.OutlayEntry", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CategoryId");

                    b.Property<int?>("OutlayId");

                    b.HasKey("ID");

                    b.HasIndex("CategoryId");

                    b.HasIndex("OutlayId");

                    b.ToTable("OutlayEntry");
                });

            modelBuilder.Entity("LaymanFinance.Models.Promo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<decimal>("PercentageOff")
                        .HasColumnType("decimal(18, 0)");

                    b.HasKey("Id");

                    b.ToTable("Promo");
                });

            modelBuilder.Entity("LaymanFinance.Models.Service", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID");

                    b.Property<string>("DescriptionFour")
                        .HasMaxLength(280);

                    b.Property<string>("DescriptionOne")
                        .IsRequired()
                        .HasMaxLength(280);

                    b.Property<string>("DescriptionThree")
                        .HasMaxLength(280);

                    b.Property<string>("DescriptionTwo")
                        .HasMaxLength(280);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<decimal>("Price")
                        .HasColumnType("money");

                    b.HasKey("Id");

                    b.ToTable("Service");
                });

            modelBuilder.Entity("LaymanFinance.Models.ServiceDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID");

                    b.Property<DateTime>("BeginDate")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime");

                    b.Property<int>("PromoId")
                        .HasColumnName("PromoID");

                    b.Property<int>("ServiceId")
                        .HasColumnName("ServiceID");

                    b.HasKey("Id");

                    b.HasIndex("PromoId");

                    b.HasIndex("ServiceId");

                    b.ToTable("ServiceDetail");
                });

            modelBuilder.Entity("LaymanFinance.Models.Testimonial", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnName("ImageURL")
                        .HasMaxLength(100);

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("ServiceId")
                        .HasColumnName("ServiceID");

                    b.Property<string>("TextOne")
                        .IsRequired()
                        .HasMaxLength(160);

                    b.Property<string>("TextThree")
                        .HasMaxLength(160);

                    b.Property<string>("TextTwo")
                        .HasMaxLength(160);

                    b.HasKey("Id");

                    b.HasIndex("ServiceId");

                    b.ToTable("Testimonial");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("LaymanFinance.Models.Inflow", b =>
                {
                    b.HasOne("LaymanFinance.Models.Category", "Category")
                        .WithMany("Inflow")
                        .HasForeignKey("CategoryId")
                        .HasConstraintName("FK_Inflow_Category");
                });

            modelBuilder.Entity("LaymanFinance.Models.Order", b =>
                {
                    b.HasOne("LaymanFinance.Models.Promo", "Promo")
                        .WithMany()
                        .HasForeignKey("PromoId");
                });

            modelBuilder.Entity("LaymanFinance.Models.Outlay", b =>
                {
                    b.HasOne("LaymanFinance.Models.Category", "Category")
                        .WithMany("Outlay")
                        .HasForeignKey("CategoryId")
                        .HasConstraintName("FK_Outlay_Category");
                });

            modelBuilder.Entity("LaymanFinance.Models.OutlayEntry", b =>
                {
                    b.HasOne("LaymanFinance.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId");

                    b.HasOne("LaymanFinance.Models.Outlay", "Outlay")
                        .WithMany()
                        .HasForeignKey("OutlayId");
                });

            modelBuilder.Entity("LaymanFinance.Models.ServiceDetail", b =>
                {
                    b.HasOne("LaymanFinance.Models.Promo", "Promo")
                        .WithMany("ServiceDetail")
                        .HasForeignKey("PromoId")
                        .HasConstraintName("FK_ServiceDetail_Promo");

                    b.HasOne("LaymanFinance.Models.Service", "Service")
                        .WithMany("ServiceDetail")
                        .HasForeignKey("ServiceId")
                        .HasConstraintName("FK_ServiceDetail_Service");
                });

            modelBuilder.Entity("LaymanFinance.Models.Testimonial", b =>
                {
                    b.HasOne("LaymanFinance.Models.Service", "Service")
                        .WithMany("Testimonial")
                        .HasForeignKey("ServiceId")
                        .HasConstraintName("FK_Testimonial_Service");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("LaymanFinance.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("LaymanFinance.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("LaymanFinance.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("LaymanFinance.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
