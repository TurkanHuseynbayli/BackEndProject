using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackEnd.DAL;
using BackEnd.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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

        public IActionResult Detail(int? id)
        {
            if (id == null) return NotFound();
            Event events = _context.Events.Where(c => c.isDelete == false)
                .Include(e => e.EventDetail).Include(e => e.EventDetail.Speaker)
                .Include(e => e.TagsEvents).ThenInclude(e => e.Tag)
                .FirstOrDefault(e => e.Id == id);
            if (events == null) NotFound();
            return View(events);
         

        }

        public IActionResult Search(string search)
        {

            List<Event> events = _context.Events.Where(c => c.isDelete == false).Where(c => c.Title.Contains(search)).ToList();
            return View(events);
        }

    }
}
