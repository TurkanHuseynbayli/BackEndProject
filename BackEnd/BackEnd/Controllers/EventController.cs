using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackEnd.DAL;
using Microsoft.AspNetCore.Mvc;

namespace BackEnd.Controllers
{
    public class EventController : Controller
    {
        private readonly AppDbContext _context;
        public EventController(AppDbContext context)
        {
         
            _context = context;
        }
        public IActionResult Index(int? page)
        {
            ViewBag.PageCount = Decimal.Ceiling((decimal)_context.Events
                .Where(blg => blg.isDelete == false).Count() / 6);
            if (page == null) return View(_context.Events.Where(e => e.isDelete == false).Take(6).ToList());
            return View(_context.Events.Where(e => e.isDelete == false).Skip(((int)page - 1) * 6).Take(6).ToList());
        }

        public IActionResult Detail()
        {

            return View();
        }

    }
}
