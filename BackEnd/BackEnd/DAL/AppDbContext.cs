using BackEnd.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Bio> Bios { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseDetail> CourseDetails { get; set; }
        public DbSet<Board> Boards { get; set; }
        public DbSet<Video> Videos { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<EventDetail> EventDetails { get; set; }
        public DbSet<Speaker> Speakers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>()
                .HasOne(cD => cD.CourseDetail)
                .WithOne(c => c.Course)
                .HasForeignKey<CourseDetail>(cD => cD.CourseId);

            modelBuilder.Entity<Event>()
                 .HasOne(eD => eD.EventDetail)
                 .WithOne(e => e.Event)
                 .HasForeignKey<EventDetail>(eD => eD.EventId);

        }

    }
}
