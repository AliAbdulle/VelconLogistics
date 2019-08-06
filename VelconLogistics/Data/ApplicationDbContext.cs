using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VelconLogistics.Models;
using VOLogistics.Models;

namespace VOLogistics.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Load> Load { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Driver> Driver { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            ApplicationUser user = new ApplicationUser
            {
                FirstName = "Ali",
                LastName = "Abdulle",
                Name = "Swift",
                UserName = "admin@admin.com",
                NormalizedUserName = "ADMIN@ADMIN.COM",
                Email = "admin@admin.com",
                NormalizedEmail = "ADMIN@ADMIN.COM",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = "7f434309-a4d9-48e9-9ebb-8803db794577",
                Id = "00000000-ffff-ffff-ffff-ffffffffffff",
            };
            var passwordHash = new PasswordHasher<ApplicationUser>();
            user.PasswordHash = passwordHash.HashPassword(user, "Admin8*");
            modelBuilder.Entity<ApplicationUser>().HasData(user);

             user = new ApplicationUser
            {
                FirstName = "Dek",
                LastName = "Haji",
                Name = "Ceva",
                UserName = "Dek@admin.com",
                NormalizedUserName = "DEK@ADMIN.COM",
                Email = "Dek@admin.com",
                NormalizedEmail = "DEK@ADMIN.COM",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = "7f434309-a4d9-48e9-9ebb-8803db794566",
                Id = "00000000-nnnn-nnnn-nnnn-nnnnnnnnnnnn",
            };
             passwordHash = new PasswordHasher<ApplicationUser>();
            user.PasswordHash = passwordHash.HashPassword(user, "Admin7*");
            modelBuilder.Entity<ApplicationUser>().HasData(user);

            user = new ApplicationUser
            {
                FirstName = "Jameka",
                LastName = "Echlos",
                Name = "Scheinder",
                UserName = "Jameka@admin.com",
                NormalizedUserName = "JAMEKA@ADMIN.COM",
                Email = "Jameka@admin.com",
                NormalizedEmail = "JAMEKA@ADMIN.COM",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = "7f434309-a4d9-48e9-9ebb-8803db794588",
                Id = "00000000-kkkk-kkkk-kkkk-kkkkkkkkkkkk",
            };
            passwordHash = new PasswordHasher<ApplicationUser>();
            user.PasswordHash = passwordHash.HashPassword(user, "Admin6*");
            modelBuilder.Entity<ApplicationUser>().HasData(user);

            modelBuilder.Entity<Driver>().HasData(
             new Driver()
             {
                 Id = 1,
                 FirstName = "Liiban",
                 LastName = "Frances",
                 Work = "Ceva"
           

             },
              new Driver()
              {
                  Id = 2,
                  FirstName = "Chris",
                  LastName = "Morgan",
                  Work = "Schneider"
           
              },
              new Driver()
              {
                  Id = 3,
                  FirstName = "Luck",
                  LastName = "Pierce",
                  Work = "Fedex"

              },
                new Driver()
                {
                    Id = 4,
                    FirstName = "Chris Hass",
                    LastName = "Elis",
                    Work = "UPS"

                }
              );

            modelBuilder.Entity<Load>().HasData(
              new Load()
              {
                  LoadId = 1,
                  Amount = 1200.00,
                  PickupDate = new DateTime(2019, 10, 01),
                  DeliverdDate = new DateTime(2019, 11, 01),
                  Location = "Nashville, TN",
                  DriverId = 2,
                  IsDeliverd = true,
                  UserId = user.Id
              },
               new Load()
               {
                   LoadId = 2,
                   Amount = 1000.00,
                   PickupDate = new DateTime(2019, 11, 05),
                   DeliverdDate = new DateTime(2019, 01, 11),
                   Location = "Atlanta, GA",
                   DriverId = 1,
                   IsDeliverd = true,
                   UserId = user.Id
               },
                new Load()
                {
                    LoadId = 3,
                    Amount = 1050.00,
                    PickupDate = new DateTime(2019, 08, 05),
                    DeliverdDate = new DateTime(2019, 08, 11),
                    Location = "Columbus, OH",
                    DriverId = 3,
                    IsDeliverd = true,
                    UserId = user.Id
                },
                 new Load()
                 {
                     LoadId = 4,
                     Amount = 1050.00,
                     PickupDate = new DateTime(2019, 09, 05),
                     DeliverdDate = new DateTime(2019, 07, 12),
                     Location = "Columbus, OH",
                     DriverId = 4,
                     IsDeliverd = true,
                     UserId = user.Id
                 }
               ) ; 


        }

    }
}
