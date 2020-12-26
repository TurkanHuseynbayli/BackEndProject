using BackEnd.DAL;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.ViewComponents
{
    public class EventViewComponent:ViewComponent
    {
        private readonly AppDbContext _context;
        public EventViewComponent(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync(int? take)
        {
            return View(await Task.FromResult(_context.Events.Where(e => e.isDelete == false).Take((int)take).ToList()));
        }
    }
}
