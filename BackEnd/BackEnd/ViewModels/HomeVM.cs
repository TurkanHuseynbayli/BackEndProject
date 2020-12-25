using BackEnd.Models;
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
        public List<Course> Courses { get; set; }
        public List<CourseDetail> CourseDetails { get; set; }
        public Video Videos { get; set; }
        public List<Board> Boards { get; set; }

    }
}
