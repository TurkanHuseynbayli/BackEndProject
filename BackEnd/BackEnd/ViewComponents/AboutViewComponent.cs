using BackEnd.DAL;
using BackEnd.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.ViewComponents
{
    public class AboutViewComponent:ViewComponent
    {
        private readonly AppDbContext _context;
        public AboutViewComponent(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            HomeVM homeVM = new HomeVM
            {
               
                Abouts = _context.Abouts.FirstOrDefault(),
            };
            return View(await Task.FromResult(homeVM));
        }
    }
}
