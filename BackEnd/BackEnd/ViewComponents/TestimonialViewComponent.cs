using BackEnd.DAL;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.ViewComponents
{
    public class TestimonialViewComponent:ViewComponent
    {
        private readonly AppDbContext _context;
        public TestimonialViewComponent(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(await Task.FromResult(_context.Testimonials.ToList()));
        }
    }
}
