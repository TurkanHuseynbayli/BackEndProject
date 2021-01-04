using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BackEnd.Models;
using BackEnd.ViewModels;
using BackEnd.DAL;
using Microsoft.EntityFrameworkCore;

namespace BackEnd.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _context;
        public HomeController(ILogger<HomeController> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM
            {
                Sliders = _context.Sliders.ToList(),
                Services = _context.Services.ToList(),
                Abouts = _context.Abouts.FirstOrDefault(),
                Courses = _context.Courses.Where(c => c.isDelete == false).FirstOrDefault(),
                CourseDetails = _context.CourseDetails.ToList(),
                Videos = _context.Videos.FirstOrDefault(),
                //Testimonials = _context.Testimonials.ToList(),
                Blogs = _context.Blogs.FirstOrDefault(),
               Tags = _context.Tags.ToList(),
                BlogDetails = _context.BlogDetails.ToList(),
                Category = _context.Category.ToList(),
                CategoryCourse = _context.CategoryCourse.ToList(),
              
            };
            return View(homeVM);

        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
