using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BackEnd.DAL;
using BackEnd.Extensions;
using BackEnd.Helpers;
using BackEnd.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackEnd.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    [Authorize(Roles = "Admin")]
    public class TeacherController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        public TeacherController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            List<Teacher> teachers = _context.Teacher.Where(t => t.IsDelete == false)
                .Include(t => t.TeacherDetail).ToList();
            return View(teachers);
        }
        #region Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Teacher teachers)
        {
            Teacher newTeacher = new Teacher();
            TeacherDetail newTeachersDetail = new TeacherDetail();


            if (teachers.Name == null)
            {
                ModelState.AddModelError("Name", "Name cannot be empty");
                return View();
            }

            if (teachers.Photo == null)
            {
                ModelState.AddModelError("Photo", "Image cannot be empty");
                return View();
            }

            if (teachers.TeacherDetail.About == null)
            {
                ModelState.AddModelError("", "About Cannot be empty");
                return View();
            }

            if (teachers.TeacherDetail.Degree == null)
            {
                ModelState.AddModelError("", "TeachersDetail Degree Cannot be empty");
                return View();
            }

            if (teachers.TeacherDetail.Email == null)
            {
                ModelState.AddModelError("", "Email Cannot be empty");
                return View();
            }

            if (teachers.TeacherDetail.Experience == null)
            {
                ModelState.AddModelError("", "Experience Cannot be empty");
                return View();
            }

            if (teachers.TeacherDetail.Hobbies == null)
            {
                ModelState.AddModelError("", "Hobbies Cannot be empty");
                return View();
            }

            if (teachers.TeacherDetail.Faculty == null)
            {
                ModelState.AddModelError("", "Faculty Cannot be empty");
                return View();
            }

            if (newTeacher == null) return NotFound();
            if (newTeachersDetail == null) return NotFound();



            if (!teachers.Photo.IsImage())
            {
                ModelState.AddModelError("Photos", $"{teachers.Photo.FileName} - not image type");
                return View(newTeacher);
            }

            string folder = Path.Combine("img", "teacher");
            string fileName = await teachers.Photo.SaveImageAsync(_env.WebRootPath, folder);
            if (fileName == null)
            {
                return Content("Error");
            }

            newTeacher.Image = fileName;
            newTeacher.Name = teachers.Name;
            newTeacher.Speciality = teachers.Speciality;
            await _context.AddAsync(newTeacher);
            await _context.SaveChangesAsync();


            newTeachersDetail.About = teachers.TeacherDetail.About;
            newTeachersDetail.Degree = teachers.TeacherDetail.Degree;
            newTeachersDetail.Experience = teachers.TeacherDetail.Experience;
            newTeachersDetail.Hobbies = teachers.TeacherDetail.Hobbies;
            newTeachersDetail.Faculty = teachers.TeacherDetail.Faculty;

            newTeachersDetail.Email = teachers.TeacherDetail.Email;
            newTeachersDetail.Phone = teachers.TeacherDetail.Phone;
            newTeachersDetail.Skype = teachers.TeacherDetail.Skype;
            newTeachersDetail.Facebook = teachers.TeacherDetail.Facebook;
            newTeachersDetail.Pinterest = teachers.TeacherDetail.Pinterest;
            newTeachersDetail.Vimeo = teachers.TeacherDetail.Vimeo;
            newTeachersDetail.Twitter = teachers.TeacherDetail.Twitter;

            newTeachersDetail.Language = teachers.TeacherDetail.Language;
            newTeachersDetail.Design = teachers.TeacherDetail.Design;
            newTeachersDetail.TeamLeader = teachers.TeacherDetail.TeamLeader;
            newTeachersDetail.Innovation = teachers.TeacherDetail.Innovation;
            newTeachersDetail.Development = teachers.TeacherDetail.Development;
            newTeachersDetail.Communication = teachers.TeacherDetail.Communication;


            newTeachersDetail.TeacherId = newTeacher.Id;
            await _context.AddAsync(newTeachersDetail);
            await _context.SaveChangesAsync();



            return RedirectToAction(nameof(Index));

        }
        #endregion

        #region Update
        public IActionResult Update(int? id)
        {
            Teacher teachers = _context.Teacher.Where(cr => cr.IsDelete == false)
                .Include(cr => cr.TeacherDetail).FirstOrDefault(cr => cr.Id == id);
            return View(teachers);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Teacher teachers)
        {
            if (id == null) return NotFound();

            Teacher oldTeacher = await _context.Teacher.Include(c => c.TeacherDetail).FirstOrDefaultAsync(c => c.Id == id);

            Course isExist = _context.Courses.Where(cr => cr.isDelete == false).FirstOrDefault(cr => cr.Id == id);

            if (isExist != null)
            {
                if (isExist.Id != oldTeacher.Id)
                {
                    ModelState.AddModelError("", "This name already has. Please write another name");
                    return Content("Null");
                }
            }

            if (teachers == null) return Content("Null");
            if (teachers.Photo != null)
            {
                if (!teachers.Photo.IsImage())
                {
                    ModelState.AddModelError("Photos", $"{teachers.Photo.FileName} - not image type");
                    return View(teachers);
                }

                string folder = Path.Combine("img", "teacher");
                string fileName = await teachers.Photo.SaveImageAsync(_env.WebRootPath, folder);
                if (fileName == null)
                {
                    return Content("Error");
                }

                Helper.DeleteImage(_env.WebRootPath, folder, oldTeacher.Image);
                oldTeacher.Image = fileName;
            }

            
            oldTeacher.Name = teachers.Name;
            oldTeacher.Speciality = teachers.Speciality;

            oldTeacher.TeacherDetail.About = teachers.TeacherDetail.About;
            oldTeacher.TeacherDetail.Degree = teachers.TeacherDetail.Degree;
            oldTeacher.TeacherDetail.Experience = teachers.TeacherDetail.Experience;
            oldTeacher.TeacherDetail.Hobbies = teachers.TeacherDetail.Hobbies;
            oldTeacher.TeacherDetail.Faculty = teachers.TeacherDetail.Faculty;
            
            oldTeacher.TeacherDetail.Email = teachers.TeacherDetail.Email;
            oldTeacher.TeacherDetail.Phone = teachers.TeacherDetail.Phone;
            oldTeacher.TeacherDetail.Skype = teachers.TeacherDetail.Skype;
            oldTeacher.TeacherDetail.Facebook = teachers.TeacherDetail.Facebook;
            oldTeacher.TeacherDetail.Pinterest = teachers.TeacherDetail.Pinterest;
            oldTeacher.TeacherDetail.Vimeo = teachers.TeacherDetail.Vimeo;
            oldTeacher.TeacherDetail.Twitter = teachers.TeacherDetail.Twitter;

            oldTeacher.TeacherDetail.Language = teachers.TeacherDetail.Language;
            oldTeacher.TeacherDetail.Design = teachers.TeacherDetail.Design;
            oldTeacher.TeacherDetail.TeamLeader = teachers.TeacherDetail.TeamLeader;
            oldTeacher.TeacherDetail.Innovation = teachers.TeacherDetail.Innovation;
            oldTeacher.TeacherDetail.Development = teachers.TeacherDetail.Development;
            oldTeacher.TeacherDetail.Communication = teachers.TeacherDetail.Communication;



            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        #endregion

        #region Detail
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return NotFound();
            Teacher teachers = await _context.Teacher.Include(c => c.TeacherDetail).FirstOrDefaultAsync(c => c.Id == id);
            if (teachers == null) return NotFound();
            return View(teachers);
        }
        #endregion
        #region Delete
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            Teacher teachers = await _context.Teacher.Include(t => t.TeacherDetail).FirstOrDefaultAsync(t => t.Id == id);
            if (teachers == null) return NotFound();
            return View(teachers);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int? id)
        {
            if (id == null) return NotFound();
            Teacher teachers = _context.Teacher.FirstOrDefault(c => c.Id == id);
            if (teachers == null) return NotFound();

            teachers.IsDelete = true;
            teachers.DeletedTime = DateTime.Now;

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        #endregion
    }
}

