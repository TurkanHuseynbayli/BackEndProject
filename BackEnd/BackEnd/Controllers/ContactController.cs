using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackEnd.DAL;
using Microsoft.AspNetCore.Mvc;

namespace BackEnd.Controllers
{
    public class ContactController : Controller
    {
        private readonly AppDbContext _context;
        public ContactController(AppDbContext context)
        {
      
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Contacts.FirstOrDefault());
        }
    }
}
