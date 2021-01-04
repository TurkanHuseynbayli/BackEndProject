using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BackEnd.DAL;
using BackEnd.Extensions;
using BackEnd.Helpers;
using BackEnd.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackEnd.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    [Authorize(Roles = "Admin")]
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        public BlogController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            List<Blog> blogs = _context.Blogs.Where(bg => bg.isDelete == false)
                .Include(bg => bg.Detail).ToList();
            return View(blogs);
        }
        public async Task<IActionResult> Detail(int? id)
        {
            Blog blog = await _context.Blogs.Include(bg => bg.Detail).FirstOrDefaultAsync(bg => bg.Id == id);
            return View(blog);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Blog blogs)
        {
            Blog newBlog = new Blog();
            BlogDetail newBlogDetail = new BlogDetail();


            if (blogs.Name == null)
            {
                ModelState.AddModelError("Name", "Name cannot be empty");
                return View();
            }

            if (blogs.Photo == null)
            {
                ModelState.AddModelError("Photo", "Image cannot be empty");
                return View();
            }

           


            if (!blogs.Photo.IsImage())
            {
                ModelState.AddModelError("Photos", $"{blogs.Photo.FileName} - not image type");
                return View(newBlog);
            }

            string folder = Path.Combine("img", "blog");
            string fileName = await blogs.Photo.SaveImageAsync(_env.WebRootPath, folder);
            if (fileName == null)
            {
                return Content("Error");
            }

            newBlog.Image = fileName;
            newBlog.Name = blogs.Name;
            newBlog.Title = blogs.Title;
            newBlog.DateTime = blogs.DateTime;
            await _context.AddAsync(newBlog);
            await _context.SaveChangesAsync();


            newBlogDetail.Description = blogs.Detail.Description;
           


            newBlogDetail.BlogId = newBlog.Id;
            await _context.AddAsync(newBlogDetail);
            await _context.SaveChangesAsync();



            return RedirectToAction(nameof(Index));

        }
        public IActionResult Update(int? id)
        {
            ViewBag.Categ = _context.Category.ToList();
            ViewBag.Tags = _context.Tags.ToList();

            Blog blogs = _context.Blogs.Include(bg => bg.Detail).FirstOrDefault(bg => bg.Id == id);
            return View(blogs);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Blog blog)
        {
            ViewBag.Categ = _context.Category.ToList();
            ViewBag.Tags = _context.Tags.ToList();
            if (id == null) return NotFound();


            Blog blogOld = await _context.Blogs.Include(c => c.Detail).FirstOrDefaultAsync(c => c.Id == id);
            Blog isExist = _context.Blogs.Where(cr => cr.isDelete == false).FirstOrDefault(cr => cr.Id == id);
            bool exist = _context.Blogs.Where(cr => cr.isDelete == false).Any(cr => cr.Title == blog.Title);

            if (exist)
            {
                if (isExist.Title != blog.Title)
                {
                    ModelState.AddModelError("Title", "This name already has. Please write another name");
                    return View(blogOld);
                }
            }

            if (blog == null) return Content("Null");
            if (blog.Photo != null)
            {
                if (!blog.Photo.IsImage())
                {
                    ModelState.AddModelError("Photo", $"{blog.Photo.FileName} - not image type");
                    return View(blogOld);
                }

                string folder = Path.Combine("img", "blog");
                string fileName = await blog.Photo.SaveImageAsync(_env.WebRootPath, folder);
                if (fileName == null)
                {
                    return Content("Error");
                }

                Helper.DeleteImage(_env.WebRootPath, folder, blogOld.Image);
                blogOld.Image = fileName;
            }

            blogOld.Title = blog.Title;
            blogOld.Detail.Description = blog.Detail.Description;
            blogOld.Name = blog.Name;

      

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            Blog blog = await _context.Blogs.FindAsync(id);
            if (blog == null) return NotFound();
            return View(blog);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int? id)
        {
            if (id == null) return RedirectToAction("ErrorPage", "Home"); ;
            Blog blog = _context.Blogs.FirstOrDefault(c => c.Id == id);
            if (blog == null) return RedirectToAction("ErrorPage", "Home"); ;

            if (!blog.isDelete)
            {
                blog.isDelete = true;
                blog.DeletedTime = DateTime.Now;
            }
            else
                blog.isDelete = false;

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        

       
        }
    }
}
