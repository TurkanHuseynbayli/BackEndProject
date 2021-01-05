using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BackEnd.DAL;
using BackEnd.Extensions;
using BackEnd.Models;
using BackEnd.Models.Categories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace BackEnd.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    [Authorize(Roles = "Admin")]
    public class CourseController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        private readonly IConfiguration _configuration;
        public CourseController(AppDbContext context, IWebHostEnvironment env, IConfiguration configuration)
        {
            _context = context;
            _env = env;
            _configuration = configuration;
        }
        public IActionResult Index()
        {
            List<Course> courses = _context.Courses.Where(cr => cr.isDelete == false)
              .Include(cr => cr.CourseDetail).Include(cr => cr.CategoryCourses).ThenInclude(cr => cr.Category).ToList();
            return View(courses);
        }

        #region Create
        public IActionResult Create()
        {
            ViewBag.Categ = _context.Category.ToList();
            ViewBag.Tags = _context.Tags.ToList();
            return View();
        }

   
        #endregion

    }
}
