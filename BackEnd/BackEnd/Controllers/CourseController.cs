using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackEnd.DAL;
using BackEnd.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackEnd.Controllers
{
    public class CourseController : Controller
    {
        private readonly AppDbContext _context;
        public CourseController( AppDbContext context)
        {
           
            _context = context;
        }
        public IActionResult Index()
        {
            //ViewBag.PageCount = Decimal.Ceiling((decimal)_context.Courses
            //   .Where(blg => blg.isDelete == false).Count() / 6);
            //ViewBag.Page = page;
            return View();
        }
        public IActionResult Detail()
        {
            //    if (id == null) return NotFound();

            //    Course course = _context.Courses.Where(c => c.isDelete == false).Include(c => c.CourseDetail)
            //        .Include(c => c.CategoryCourses).ThenInclude(c => c.Category)
            //        .FirstOrDefault(c => c.Id == id);

            //    if (course == null) NotFound();
            return View();
        }
    }
}
