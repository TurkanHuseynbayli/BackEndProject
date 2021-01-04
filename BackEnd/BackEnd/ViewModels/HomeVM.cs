using BackEnd.Models;
using BackEnd.Models.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.ViewModels
{
    public class HomeVM
    {
        public List<Slider> Sliders { get; set; }
        public List<Service> Services { get; set; }
        public About Abouts { get; set; }
        public Course Courses { get; set; }
        public List<CourseDetail> CourseDetails { get; set; }
        public Video Videos { get; set; }
        public List<Board> Boards { get; set; }
        //public List<Testimonial> Testimonials { get; set; }
        public Blog Blogs { get; set; }
        public List<Tag> Tags { get; set; }
    
        public List<BlogDetail> BlogDetails { get; set; }
        public List<Category> Category { get; set; }
        public List<CategoryCourse> CategoryCourse { get; set; }
    

    }
}
