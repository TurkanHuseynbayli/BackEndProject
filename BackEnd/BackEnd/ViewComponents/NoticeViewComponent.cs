using BackEnd.DAL;
using BackEnd.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.ViewComponents
{
    public class NoticeViewComponent : ViewComponent
    {
        private readonly AppDbContext _context;
        public NoticeViewComponent(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            HomeVM homeVM = new HomeVM
            {
                Videos = _context.Videos.FirstOrDefault(),
                Boards = _context.Boards.ToList(),
                
            };
            return View(await Task.FromResult(homeVM));
        }
    }
}
