using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BackEnd.DAL;
using BackEnd.Helpers;
using BackEnd.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace BackEnd.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    [Authorize(Roles = "Admin")]
    public class TestimonialController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        public TestimonialController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        
            public IActionResult Index()
            {
                return View(_context.Testimonials.ToList());
            }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Testimonial testimonial)
        {

            if (ModelState["Photo"].ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid)
            {
                return View();
            }

            //if (!testimonial.Photo.IsImage())
            //{
            //    ModelState.AddModelError("Photo", "Zehmet olmasa shekil formati sechin");
            //    return View();
            //}

            //if (testimonial.Photo.MaxLength(2000))
            //{
            //    ModelState.AddModelError("Photo", "Shekilin olchusu max 200kb ola biler");
            //    return View();
            //}

           

            //string path = Path.Combine("img", "testimonial");

            //string fileName = await testimonial.Photo.SaveImg(_env.WebRootPath, path);
            Testimonial newTestimonal = new Testimonial();

            newTestimonal.Name = testimonial.Name;
            newTestimonal.Description = testimonial.Description;
            //newTestimonal.Image = fileName;


            await _context.Testimonials.AddAsync(newTestimonal);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }
        public IActionResult Update(int? id)
        {
            if (id == null) return NotFound();
            Testimonial testimonial = _context.Testimonials.FirstOrDefault(p => p.Id == id);
            if (testimonial == null) return NotFound();
            return View(testimonial);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Testimonial testimonial)
        {
            if (!ModelState.IsValid) return View();
            if (id == null) return NotFound();
            Testimonial dbtestimonial = await _context.Testimonials.FindAsync(id);
            if (dbtestimonial == null) return NotFound();
            if (testimonial.Photo != null)
            {
                if (ModelState["Photo"].ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid)
                {
                    return View();
                }




                string path = Path.Combine("img", "testimonial");
                Helper.DeleteImage(_env.WebRootPath, path, dbtestimonial.Image);

               

            }
            dbtestimonial.Name = testimonial.Name;
            dbtestimonial.Description = testimonial.Description;
          



            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

    }
}
