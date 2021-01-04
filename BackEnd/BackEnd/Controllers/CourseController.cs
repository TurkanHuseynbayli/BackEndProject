using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackEnd.DAL;
using BackEnd.Models;
using BackEnd.ViewModels;
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
            return View(_context.Category.ToList());
            
        }
        public IActionResult Detail(int? id)
        {
            if (id == null) return NotFound();

            HomeVM homeVM = new HomeVM()
            {
                Category = _context.Category.ToList(),
                Courses = _context.Courses.Where(c => c.isDelete == false).Include(c => c.CourseDetail)
                .Include(c => c.CategoryCourses).ThenInclude(c => c.Category)
                .Include(c => c.TagCourses).ThenInclude(c => c.Tag)
                .FirstOrDefault(c => c.Id == id)
            };
            return View(homeVM);

            //Course course = _context.Courses.Where(c => c.isDelete == false).Include(c => c.CourseDetail)
            //    .Include(c => c.CategoryCourses).ThenInclude(c => c.Category)
            //    .FirstOrDefault(c => c.Id == id);

            //if (course == null) NotFound();
            //return View(course);
        }
        public IActionResult Search(string search)
        {

              List<Course> course = _context.Courses.Where(c => c.isDelete == false ).Where(c=>c.Name.Contains(search)).ToList();
            return View(course);
        }
    }
}
