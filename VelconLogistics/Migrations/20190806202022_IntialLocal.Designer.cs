﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VOLogistics.Data;

namespace VelconLogistics.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20190806202022_IntialLocal")]
    partial class IntialLocal
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

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

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("VOLogistics.Models.Driver", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApplicationUserId");

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("Work")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.ToTable("Driver");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "Liiban",
                            LastName = "Frances",
                            Work = "Ceva"
                        },
                        new
                        {
                            Id = 2,
                            FirstName = "Chris",
                            LastName = "Morgan",
                            Work = "Schneider"
                        },
                        new
                        {
                            Id = 3,
                            FirstName = "Luck",
                            LastName = "Pierce",
                            Work = "Fedex"
                        },
                        new
                        {
                            Id = 4,
                            FirstName = "Chris Hass",
                            LastName = "Elis",
                            Work = "UPS"
                        });
                });

            modelBuilder.Entity("VOLogistics.Models.Load", b =>
                {
                    b.Property<int>("LoadId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Amount");

                    b.Property<string>("CompanyName");

                    b.Property<DateTime>("DeliverdDate");

                    b.Property<int>("DriverId");

                    b.Property<bool>("IsDeliverd");

                    b.Property<string>("Location")
                        .IsRequired();

                    b.Property<DateTime>("PickupDate");

                    b.Property<string>("UserId");

                    b.HasKey("LoadId");

                    b.HasIndex("DriverId");

                    b.HasIndex("UserId");

                    b.ToTable("Load");

                    b.HasData(
                        new
                        {
                            LoadId = 1,
                            Amount = 1200.0,
                            CompanyName = "Ceva",
                            DeliverdDate = new DateTime(2019, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DriverId = 2,
                            IsDeliverd = true,
                            Location = "Nashville, TN",
                            PickupDate = new DateTime(2019, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = "00000000-kkkk-kkkk-kkkk-kkkkkkkkkkkk"
                        },
                        new
                        {
                            LoadId = 2,
                            Amount = 1000.0,
                            CompanyName = "Schneider",
                            DeliverdDate = new DateTime(2019, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DriverId = 1,
                            IsDeliverd = true,
                            Location = "Atlanta, GA",
                            PickupDate = new DateTime(2019, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = "00000000-kkkk-kkkk-kkkk-kkkkkkkkkkkk"
                        },
                        new
                        {
                            LoadId = 3,
                            Amount = 1050.0,
                            CompanyName = "FedEx",
                            DeliverdDate = new DateTime(2019, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DriverId = 3,
                            IsDeliverd = true,
                            Location = "Columbus, OH",
                            PickupDate = new DateTime(2019, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = "00000000-kkkk-kkkk-kkkk-kkkkkkkkkkkk"
                        },
                        new
                        {
                            LoadId = 4,
                            Amount = 1050.0,
                            CompanyName = "UPS",
                            DeliverdDate = new DateTime(2019, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DriverId = 4,
                            IsDeliverd = true,
                            Location = "Columbus, OH",
                            PickupDate = new DateTime(2019, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = "00000000-kkkk-kkkk-kkkk-kkkkkkkkkkkk"
                        });
                });

            modelBuilder.Entity("VelconLogistics.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("Name")
                        .IsRequired();

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

                    b.HasData(
                        new
                        {
                            Id = "00000000-ffff-ffff-ffff-ffffffffffff",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "02459b5e-f443-4ced-93c4-ccc36e6642cb",
                            Email = "admin@admin.com",
                            EmailConfirmed = true,
                            FirstName = "Ali",
                            LastName = "Abdulle",
                            LockoutEnabled = false,
                            Name = "Swift",
                            NormalizedEmail = "ADMIN@ADMIN.COM",
                            NormalizedUserName = "ADMIN@ADMIN.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEJLZCmQ+dNoe5vKwNsSz7nL6RHfv4QE2nyyN9sad08AvbkLIOtgvkv6pfoc6KW14ew==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "7f434309-a4d9-48e9-9ebb-8803db794577",
                            TwoFactorEnabled = false,
                            UserName = "admin@admin.com"
                        },
                        new
                        {
                            Id = "00000000-nnnn-nnnn-nnnn-nnnnnnnnnnnn",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "98d87070-ed7e-4187-91fa-f84f054f3cdb",
                            Email = "Dek@admin.com",
                            EmailConfirmed = true,
                            FirstName = "Dek",
                            LastName = "Haji",
                            LockoutEnabled = false,
                            Name = "Ceva",
                            NormalizedEmail = "DEK@ADMIN.COM",
                            NormalizedUserName = "DEK@ADMIN.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAELBF+VRaS7n8X1jrCp7xnjz1XnXc7aHEypgsGNcurrWOkkGbq+CKWf6JEOAhbsBIUg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "7f434309-a4d9-48e9-9ebb-8803db794566",
                            TwoFactorEnabled = false,
                            UserName = "Dek@admin.com"
                        },
                        new
                        {
                            Id = "00000000-kkkk-kkkk-kkkk-kkkkkkkkkkkk",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "a827c924-103e-46c6-8497-7aab6ae24369",
                            Email = "Jameka@admin.com",
                            EmailConfirmed = true,
                            FirstName = "Jameka",
                            LastName = "Echlos",
                            LockoutEnabled = false,
                            Name = "Scheinder",
                            NormalizedEmail = "JAMEKA@ADMIN.COM",
                            NormalizedUserName = "JAMEKA@ADMIN.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEJooy14FI4EUpDcGPdSHY3c4mcVlG7xA+GhA+m/YxdXTF4p80AWNFX7G+U8B/JisWg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "7f434309-a4d9-48e9-9ebb-8803db794588",
                            TwoFactorEnabled = false,
                            UserName = "Jameka@admin.com"
                        });
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
                    b.HasOne("VelconLogistics.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("VelconLogistics.Models.ApplicationUser")
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

                    b.HasOne("VelconLogistics.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("VelconLogistics.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("VOLogistics.Models.Driver", b =>
                {
                    b.HasOne("VelconLogistics.Models.ApplicationUser")
                        .WithMany("Driver")
                        .HasForeignKey("ApplicationUserId");
                });

            modelBuilder.Entity("VOLogistics.Models.Load", b =>
                {
                    b.HasOne("VOLogistics.Models.Driver", "Driver")
                        .WithMany("Loads")
                        .HasForeignKey("DriverId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("VelconLogistics.Models.ApplicationUser", "User")
                        .WithMany("Load")
                        .HasForeignKey("UserId");
                });
#pragma warning restore 612, 618
        }
    }
}