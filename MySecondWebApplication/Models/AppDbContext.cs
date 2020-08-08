using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using MySecondWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySecondWebApplication.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { 
        
        }
        public DbSet<Student> students { get; set; }
        public DbSet<School> schools { get; set; }
        public DbSet<UserModel> users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }
    }
}
public static class ModelBuilderExtensions
{
    public static void Seed(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<UserModel>()
       .HasIndex(u => u.Email)
       .IsUnique();

        modelBuilder.Entity<School>().HasData(
            new School { 
            Id=1,
            Name="Saraswati vidya mandir"
            });
        modelBuilder.Entity<Student>().HasData(
            new Student
            {
              Id=1,
              Address="Bhopal",
              Name="Naman Dubey",
              SchoolId=1
            });
    }
}