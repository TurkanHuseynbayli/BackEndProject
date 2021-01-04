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
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;
        public BlogController(AppDbContext context)
        {

            _context = context;
        }
        public IActionResult Index(int? page)
        {
            ViewBag.PageCount = Math.Ceiling((decimal)_context.Blogs.Count() / 3);
            ViewBag.Page = page;
            if (page == null)
            {
                return View(_context.Blogs.OrderByDescending(p => p.Id).Take(3).ToList());
            }
            else
            {
                return View(_context.Blogs.OrderByDescending(p => p.Id).Skip(((int)page - 1) * 3).Take(3).ToList());
            }
        }
        public IActionResult Detail(int? id)
        {
            if (id == null) return NotFound();
            HomeVM homeVM = new HomeVM()
            {
               
                Category = _context.Category.ToList(),
                Blogs = _context.Blogs.Where(blg => blg.isDelete == false).Include(blg => blg.Detail).Include(blg => blg.TagBlogs)
                  .ThenInclude(blg => blg.Tag).FirstOrDefault(blg => blg.Id == id)

            };
            return View(homeVM);

            //Blog blogs = _context.Blogs.Where(blg => blg.isDelete == false).Include(blg => blg.Detail).Include(blg => blg.TagBlogs)
            //    .ThenInclude(blg => blg.Tag).FirstOrDefault(blg => blg.Id == id);

            //return View(blogs);
        }
        public IActionResult Search(string search)
        {

            List<Blog> blogs = _context.Blogs.Where(c => c.isDelete == false).Where(c => c.Name.Contains(search)).ToList();
            return View(blogs);
        }
    }
}
