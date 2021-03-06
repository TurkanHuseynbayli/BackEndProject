﻿using BackEnd.Models;
using BackEnd.Models.Categories;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.DAL
{
    public class AppDbContext:IdentityDbContext<AppUser>
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
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogDetail> BlogDetails { get; set; }
        public DbSet<Teacher> Teacher { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<CategoryCourse> CategoryCourse { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<TagCourse> TagCourses { get; set; }
        public DbSet<TagBlog> TagBlogs { get; set; }
        public DbSet<TagEvent> TagEvents { get; set; }
        public DbSet<TeacherDetail> TeacherDetail { get; set; }
        public DbSet<Subscribe> Subscribes { get; set; }
        public DbSet<SubscribedEmail> SubscribedEmails { get; set; }

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

            modelBuilder.Entity<Blog>()
               .HasOne(bD => bD.Detail)
               .WithOne(b => b.Blog)
               .HasForeignKey<BlogDetail>(bD => bD.BlogId);

            //modelBuilder.Entity<Teacher>()
            //  .HasOne(tD => tD.Detail)
            //  .WithOne(t => t.Teacher)
            //  .HasForeignKey<TeacherDetail>(tD => tD.TeacherId);

            base.OnModelCreating(modelBuilder);
        }

    }
}
