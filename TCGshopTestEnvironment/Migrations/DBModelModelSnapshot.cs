﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using TCGshopTestEnvironment.Models;

namespace TCGshopTestEnvironment.Migrations
{
    [DbContext(typeof(DBModel))]
    partial class DBModelModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.0-preview2-35157")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

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
                        .HasName("RoleNameIndex");

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

            modelBuilder.Entity("TCGshopTestEnvironment.Models.Category", b =>
                {
                    b.Property<string>("CategoryName")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.HasKey("CategoryName");

                    b.ToTable("categories");
                });

            modelBuilder.Entity("TCGshopTestEnvironment.Models.JoinTables.ProductCategory", b =>
                {
                    b.Property<int>("ProductId");

                    b.Property<string>("CategoryName");

                    b.HasKey("ProductId", "CategoryName");

                    b.HasIndex("CategoryName");

                    b.ToTable("ProductCategory");
                });

            modelBuilder.Entity("TCGshopTestEnvironment.Models.Orders", b =>
                {
                    b.Property<int>("Order_ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Payment_Status");

                    b.Property<DateTime>("Purchage_Date");

                    b.Property<DateTime>("Shipped_Date");

                    b.Property<string>("Shipping_Status");

                    b.HasKey("Order_ID");

                    b.ToTable("orders");
                });

            modelBuilder.Entity("TCGshopTestEnvironment.Models.Pictures", b =>
                {
                    b.Property<int>("Picture_ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Picture");

                    b.HasKey("Picture_ID");

                    b.ToTable("pictures");
                });

            modelBuilder.Entity("TCGshopTestEnvironment.Models.Products", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("DateUpdated");

                    b.Property<string>("Description");

                    b.Property<string>("Grade");

                    b.Property<string>("ImageUrl");

                    b.Property<string>("Name");

                    b.Property<string>("OwnerId");

                    b.Property<float>("Price");

                    b.Property<int>("Stock");

                    b.Property<int>("ViewsDetails");

                    b.Property<int>("ViewsListed");

                    b.HasKey("ProductId");

                    b.HasIndex("OwnerId");

                    b.ToTable("products");
                });

            modelBuilder.Entity("TCGshopTestEnvironment.Models.Statistics", b =>
                {
                    b.Property<int>("Static_ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.HasKey("Static_ID");

                    b.ToTable("statistics");
                });

            modelBuilder.Entity("TCGshopTestEnvironment.Models.UserAccount", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("Address");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Country");

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

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

                    b.Property<string>("ZipCode");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("TCGshopTestEnvironment.Models.Whishlist", b =>
                {
                    b.Property<int>("Whishlist_ID")
                        .ValueGeneratedOnAdd();

                    b.HasKey("Whishlist_ID");

                    b.ToTable("whishlists");
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
                    b.HasOne("TCGshopTestEnvironment.Models.UserAccount")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("TCGshopTestEnvironment.Models.UserAccount")
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

                    b.HasOne("TCGshopTestEnvironment.Models.UserAccount")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("TCGshopTestEnvironment.Models.UserAccount")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TCGshopTestEnvironment.Models.JoinTables.ProductCategory", b =>
                {
                    b.HasOne("TCGshopTestEnvironment.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryName")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TCGshopTestEnvironment.Models.Products", "Products")
                        .WithMany("Category")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TCGshopTestEnvironment.Models.Products", b =>
                {
                    b.HasOne("TCGshopTestEnvironment.Models.UserAccount", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerId");
                });
#pragma warning restore 612, 618
        }
    }
}
