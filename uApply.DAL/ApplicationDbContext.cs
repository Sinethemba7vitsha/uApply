using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uApply.Data.Models;
using uApply.Data.Models.Education;
using uApply.Data.Models.Location;


namespace uApply.DAL
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {

        }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Parent> Parents { get; set; }
        public DbSet<Learner> Learners { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<SchoolApplication> SchoolApplications { get; set; }
        public DbSet<SchoolLevel> SchoolLevels { get; set; }
        public DbSet<Town> Towns { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<Title> Titles { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Nationality> Nationalities { get; set; }
        public DbSet<Race> Races { get; set; }
        public DbSet<Status> ApplicationStatuses { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            foreach(var foreignKey in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                foreignKey.DeleteBehavior = DeleteBehavior.Restrict;
            }

            modelBuilder.Entity<Province>().HasData(new Province()
            {
                Id = 1,
                Name = "Free State"
            });

            modelBuilder.Entity<District>().HasData(new District()
            {
                Id = 1,
                Name = "Mangaung",
                ProvinceId = 1
            });

            modelBuilder.Entity<District>().HasData(new District()
            {
                Id = 2,
                Name = "Lejweleputswa",
                ProvinceId = 1
            });

            modelBuilder.Entity<District>().HasData(new District()
            {
                Id = 3,
                Name = "Xhariep",
                ProvinceId = 1
            });

            //Town 2 per District
            modelBuilder.Entity<Town>().HasData(new Town()
            {
                Id = 1,
                Name = "Bloem",
                DistrictId = 1
            });
            modelBuilder.Entity<Town>().HasData(new Town()
            {
                Id = 2,
                Name = "Botshabelo",
                DistrictId = 1

            });
            modelBuilder.Entity<Town>().HasData(new Town()
            {
                Id = 3,
                Name = "phuthaditjhaba",
                DistrictId = 2

            });
            modelBuilder.Entity<Town>().HasData(new Town()
            {
                Id = 4,
                Name = "betlehem",
                DistrictId = 2

            });
            modelBuilder.Entity<Town>().HasData(new Town()
            {
                Id = 5,
                Name = "Frankfort",
                DistrictId = 3

            });
            modelBuilder.Entity<Town>().HasData(new Town()
            {
                Id = 6,
                Name = "Ficksburg",
                DistrictId = 3

            });

            //Nationlity - RSA And Other
            modelBuilder.Entity<Nationality>().HasData(new Nationality()
            {
                Id = 1,
                Name = "South Africa"
            });
            modelBuilder.Entity<Nationality>().HasData(new Nationality()
            {
                Id = 2,
                Name = "Other"
            });

            //Language  - 3
            modelBuilder.Entity<Language>().HasData(new Language()
            {
                Id = 1,
                Name = "English"
            });
            modelBuilder.Entity<Language>().HasData(new Language()
            {
                Id = 2,
                Name = "Sesotho"
            });
            modelBuilder.Entity<Language>().HasData(new Language()
            {
                Id = 3,
                Name = "isiXhosa"
            });

            // Race
            modelBuilder.Entity<Race>().HasData(new Race()
            {
                Id = 1,
                Name = "African"
            });
            modelBuilder.Entity<Race>().HasData(new Race()
            {
                Id = 2,
                Name = "White"
            });

            //Titles
            modelBuilder.Entity<Title>().HasData(new Title()
            {
                Id = 1,
                Name = "Mr"
            });
            modelBuilder.Entity<Title>().HasData(new Title()
            {
                Id = 2,
                Name = "Miss"
            });
            modelBuilder.Entity<Title>().HasData(new Title()
            {
                Id = 3,
                Name = "Mrs"
            });
            modelBuilder.Entity<Title>().HasData(new Title()
            {
                Id = 4,
                Name = "Dr"
            });

            //Gender
            modelBuilder.Entity<Gender>().HasData(new Gender()
            {
                Id = 1,
                Name = "Male"
            });
            modelBuilder.Entity<Gender>().HasData(new Gender()
            {
                Id = 2,
                Name = "Female"
            });

            modelBuilder.Entity<Grade>().HasData(new Grade()
            {
                Id = 1,
                Name = "8",
                SchoolLevelId = 2
            });
            modelBuilder.Entity<Grade>().HasData(new Grade()
            {
                Id = 2,
                Name = "9",
                SchoolLevelId = 2
            });
            modelBuilder.Entity<Grade>().HasData(new Grade()
            {
                Id = 3,
                Name = "10",
                SchoolLevelId = 2
            });
            modelBuilder.Entity<Grade>().HasData(new Grade()
            {
                Id = 4,
                Name = "11",
                SchoolLevelId = 2
            });
            modelBuilder.Entity<Grade>().HasData(new Grade()
            {
                Id = 5,
                Name = "12",
                SchoolLevelId = 2
            });

            //SchoolLevel
            modelBuilder.Entity<SchoolLevel>().HasData(new SchoolLevel()
            {
                Id = 1,
                Name = "Primary School"
            });

            modelBuilder.Entity<SchoolLevel>().HasData(new SchoolLevel()
            {
                Id = 2,
                Name = "High School"
            });

            //Schools
            
            modelBuilder.Entity<School>().HasData(new School()
            {
                Id = 1,
                Name = "Bloemfontein High School",
                EmisNumber = 896541231,
                TownId = 1,
                SchoolLevelId = 2,
                Email = "bloem@gmail.com",
                Password = "pass123"
            });
            modelBuilder.Entity<School>().HasData(new School()
            {
                Id = 2,
                Name = "HTS louis Botha High School",
                EmisNumber = 123456789,
                TownId = 1,
                Email = "botha@gmail.com",
                Password = "pass123",
                SchoolLevelId = 2,
            });
            modelBuilder.Entity<School>().HasData(new School()
            {
                Id = 3,
                Name = "Navalsig High School",
                EmisNumber = 456985213,
                TownId = 1,
                SchoolLevelId = 2,
                Email = "navalsig@gmail.com",
                Password = "pass123",
            });
            modelBuilder.Entity<School>().HasData(new School()
            {
                Id = 4,
                Name = "Rose View Primary School",
                EmisNumber = 6458322544,
                TownId = 1,
                SchoolLevelId = 1,
                Email = "rose@gmail.com",
                Password = "pass123",
            });
            modelBuilder.Entity<School>().HasData(new School()
            {
                Id = 5,
                Name = "Castle Bridge Primary School",
                EmisNumber = 7532156498,
                TownId = 1,
                SchoolLevelId = 1,
                Email = "castle@gmail.com",
                Password = "pass123"
            });
            modelBuilder.Entity<School>().HasData(new School()
            {
                Id = 6,
                Name = "Mangaung Primary School",
                EmisNumber = 9632587412,
                TownId = 1,
                SchoolLevelId = 1,
                Email = "mangaung@gmail.com",
                Password = "pass123",
            });


            //Parent
            modelBuilder.Entity<Parent>().HasData(new Parent()
            {
                Id = 1,
                FullNames = "lesetja Frans",
                Surname = "Selepe",
                IdNumber = 0003265453088,
                PhoneNumber = "0636517935",
                Email = "lesetjaofficial26@gmail.com",
                Password = "@Sijo4C#",
                StreetAddress = "10360 Poulos Village",
                Surburb = "Bakenberg",
                PostalCode = 0611,
                TownId = 1,
                TitleId = 1,
                GenderId = 1,
                NationalityId = 1,
                RaceId = 1,
                LanguageId = 2
            });

            //Learner
            modelBuilder.Entity<Learner>().HasData(new Learner()
            {
                Id = 1,
                ParentId = 1,
                FullNames = "Sne Maxwell",
                Surname = "Selepe",
                IdNumber = 9802356508984,
                PhoneNumber = "0645698789",
                Email = "maxvitsha@gmail.com",
                Password = "@Sijo4C#",
                StreetAddress = "10360 Poulos Village",
                Surburb = "Bakenberg",
                PostalCode = 0611,
                TownId = 1,
                TitleId = 1,
                GenderId = 1,
                NationalityId = 1,
                RaceId = 1,
                LanguageId = 2,
                GradeId = 1
            });

            //Application
            modelBuilder.Entity<SchoolApplication>().HasData(new SchoolApplication()
            {
                Id = 1,
                StatusId = 1,
                Created = DateTime.Now,
                SchoolId = 1,
                LearnerId = 1,
                GradeId = 1
            });
            modelBuilder.Entity<SchoolApplication>().HasData(new SchoolApplication()
            {
                Id = 2,
                StatusId = 2,
                Created = DateTime.Now,
                SchoolId = 2,
                LearnerId = 1,
                GradeId = 1
            });
            modelBuilder.Entity<SchoolApplication>().HasData(new SchoolApplication()
            {
                Id = 3,
                StatusId = 2,
                Created = DateTime.Now,
                SchoolId = 3,
                LearnerId = 1,
                GradeId = 1
            });
            modelBuilder.Entity<SchoolApplication>().HasData(new SchoolApplication()
            {
                Id = 4,
                StatusId = 2,
                Created = DateTime.Now,
                SchoolId = 4,
                LearnerId = 1,
                GradeId = 4
            });
            modelBuilder.Entity<SchoolApplication>().HasData(new SchoolApplication()
            {
                Id = 5,
                StatusId = 3,
                Created = DateTime.Now,
                SchoolId = 5,
                LearnerId = 1,
                GradeId = 1
            });
             modelBuilder.Entity<SchoolApplication>().HasData(new SchoolApplication()
            {
                Id = 6,
                StatusId = 4,
                Created = DateTime.Now,
                SchoolId = 6,
                LearnerId = 1,
                GradeId = 5
            });

            //Status
            modelBuilder.Entity<Status>().HasData(new Status()
            {
                Id = 1,
                Name = "Not Yet attended"
            });
            modelBuilder.Entity<Status>().HasData(new Status()
            {
                Id = 2,
                Name = "Processing"
            });
            modelBuilder.Entity<Status>().HasData(new Status()
            {
                Id = 3,
                Name = "Admitted"
            });
            modelBuilder.Entity<Status>().HasData(new Status()
            {
                Id = 4,
                Name = "Rejected"
            });

        }
    }
}
