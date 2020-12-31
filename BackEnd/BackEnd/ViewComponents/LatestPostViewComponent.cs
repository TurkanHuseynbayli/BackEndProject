using BackEnd.DAL;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.ViewComponents
{
    public class LatestPostViewComponent:ViewComponent
    {
        private readonly AppDbContext _context;
        public LatestPostViewComponent(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(_context.Blogs.Where(blog => blog.isDelete == false)
                .OrderByDescending(blog => blog.DateTime).Take(3).ToList());
        }
    }
}
