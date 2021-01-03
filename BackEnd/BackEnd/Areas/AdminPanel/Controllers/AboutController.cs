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
    public class AboutController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        public AboutController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            About about = _context.Abouts.FirstOrDefault();
            return View(about);
        }
        public async Task<IActionResult> Update(int? id)
        {
            if (id == null) return NotFound();
            About about = await _context.Abouts.FindAsync(id);
            if (about == null) return NotFound();
            return View(about);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, About about)
        {
            if (id == null) return NotFound();
            About dbabout = await _context.Abouts.FindAsync(id);
            if (dbabout == null) return NotFound();
            if (about.Photo != null)
            {
                if (ModelState["Photo"].ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid)
                {
                    return View();
                }


                string path = Path.Combine("img", "about");
                Helper.DeleteImage(_env.WebRootPath, path, dbabout.Image);
              

            }
            //dbabout.Image = about.Image;
            dbabout.Description = about.Description;
            dbabout.Title = about.Title;

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

    }
}
