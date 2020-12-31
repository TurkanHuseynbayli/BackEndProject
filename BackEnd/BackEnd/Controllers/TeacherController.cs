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
    public class TeacherController : Controller
    {
        private readonly AppDbContext _context;
        public TeacherController( AppDbContext context)
        {
            
            _context = context;
        }

        public List<Teacher> Teachers { get; private set; }

        public IActionResult Index()
        {
           
            return View();
        }
        public IActionResult Detail(int? id)
        {
            if (id == null) return NotFound();

            Teacher teachers = _context.Teacher.Where(tc => tc.IsDelete == false)
                .Include(teach => teach.TeacherDetail).FirstOrDefault(teach => teach.Id == id);

            return View(teachers);
        }

    }
}
