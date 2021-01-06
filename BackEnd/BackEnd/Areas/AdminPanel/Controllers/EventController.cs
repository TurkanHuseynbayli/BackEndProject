using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using BackEnd.DAL;
using BackEnd.Extensions;
using BackEnd.Helpers;
using BackEnd.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace BackEnd.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    [Authorize(Roles = "Admin")]
    public class EventController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly IWebHostEnvironment _env;

        public EventController(AppDbContext context, UserManager<AppUser> userManager, IWebHostEnvironment env)
        {
            _context = context;
            _userManager = userManager;
            _env = env;
        }
        public IActionResult Index()
        {
            List<Event> events = _context.Events.Where(cr => cr.isDelete == false)
                .Include(cr => cr.EventDetail).Include(cr => cr.EventDetail.Speaker).Include(cr => cr.TagsEvents).ThenInclude(cr => cr.Tag).ToList();
            return View(events);
        }
        //CREATE START
        public IActionResult Create()
        {
            ViewBag.Tags = _context.Tags.ToList();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Event events, List<int> TagsId, List<int> SpeakerId)
        {
            ViewBag.Tags = _context.Tags.ToList();

            bool isExist = _context.Events.Where(cr => cr.isDelete == false)
                .Any(cr => cr.Title == events.Title);

            Event newEvent = new Event
            {
                Title = events.Title,
            };

            EventDetail newCourseDetail = new EventDetail();
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Error");
                return View();
            }

            if (!events.Photo.IsImage())
            {
                ModelState.AddModelError("Event.Photo", $"{events.Photo.FileName} - not image type");
                return View(newEvent);
            }

            string folder = Path.Combine("img", "event");
            string fileName = await events.Photo.SaveImageAsync(_env.WebRootPath, folder);
            if (fileName == null)
            {
                return NotFound();
            }
            newEvent.Image = fileName;

        
            List<TagEvent> tagCourses = new List<TagEvent>();


            if (TagsId.Count == 0)
            {
                ModelState.AddModelError("", "Tag cannot be empty");
                return View();
            }

            foreach (var item in TagsId)
            {
                TagEvent tagCourse = new TagEvent()
                {
                    EventId = newEvent.Id,
                    TagId = item
                };
                tagCourses.Add(tagCourse);
            }

        
            newEvent.TagsEvents = tagCourses;
            await _context.Events.AddAsync(newEvent);
            await _context.SaveChangesAsync();

            //SEND EMAIL 

            //List<SubscribedEmail> emails = _context.SubscribedEmails.Where(e => e.HasDeleted == false).ToList();
            //foreach (SubscribedEmail email in emails)
            //{
            //    SendEmail(email.Email, "Yeni bir event yaradildi.", "<h1>Yeni bir event yaradildi</h1>");
            //}


            newCourseDetail.Description = events.EventDetail.Description;

            newCourseDetail.EventId = newEvent.Id;
            await _context.AddAsync(newCourseDetail);
            await _context.SaveChangesAsync();
          

            return RedirectToAction(nameof(Index));
        }
        //CREATE END
        public IActionResult Detail(int? id)
        {
            Event @event = _context.Events.Include(ev => ev.EventDetail).FirstOrDefault(ev => ev.Id == id);
            return View(@event);
        }

        //UPDATE START

        public IActionResult Update(int? id)
        {
            ViewBag.Categ = _context.Category.ToList();
            ViewBag.Tags = _context.Tags.ToList();

            Event blogs = _context.Events.Include(blg => blg.EventDetail).FirstOrDefault(blg => blg.Id == id);
            return View(blogs);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Event events)
        {
            ViewBag.Tags = _context.Tags.ToList();
            if (id == null) return NotFound();

            Event eventOld = await _context.Events.Include(c => c.EventDetail).FirstOrDefaultAsync(c => c.Id == id);
            Event isExist = _context.Events.Where(cr => cr.isDelete == false).FirstOrDefault(cr => cr.Id == id);
            bool exist = _context.Events.Where(cr => cr.isDelete == false).Any(cr => cr.Title == events.Title);

            if (exist)
            {
                if (isExist.Title != events.Title)
                {
                    ModelState.AddModelError("Title", "This name already has.");
                    return View(eventOld);
                }
            }

            if (events == null) return Content("Null");
            if (events.Photo != null)
            {
                if (!events.Photo.IsImage())
                {
                    ModelState.AddModelError("Photo", $"{events.Photo.FileName} - not image type");
                    return View(eventOld);
                }

                string folder = Path.Combine("img", "event");
                string fileName = await events.Photo.SaveImageAsync(_env.WebRootPath, folder);
                if (fileName == null)
                {
                    return NotFound();
                }

                Helper.DeleteImage(_env.WebRootPath, folder, eventOld.Image);
                eventOld.Image = fileName;
            }


        
            eventOld.Title = events.Title;
            eventOld.EventDetail.Description = events.EventDetail.Description;
            eventOld.Date = events.Date;
            eventOld.Place = events.Place;
           


            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
        //UPDATE END

        //DELETE START
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            Event @event = await _context.Events.FindAsync(id);
            if (@event == null) return NotFound();
            return View(@event);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int? id)
        {
            if (id == null) return NotFound();
            Event @event = _context.Events.FirstOrDefault(c => c.Id == id);
            if (@event == null) return NotFound();

            if (!@event.isDelete)
            {
                @event.isDelete = true;
                @event.DeletedTime = DateTime.Now;
            }
            else
                @event.isDelete = false;

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        //DELETE END

        //SEND EMAIL 

        //public void SendEmail(string email, string subject, string htmlMessage)
        //{
        //    System.Net.Mail.SmtpClient client = new System.Net.Mail.SmtpClient()
        //    {
        //        Host = "smtp.gmail.com",
        //        Port = 587,
        //        EnableSsl = true,
        //        DeliveryMethod = SmtpDeliveryMethod.Network,
        //        UseDefaultCredentials = false,
        //        Credentials = new NetworkCredential()
        //        {
        //            UserName = "turkanhuseyinbeyli@gmail.com",
        //            Password = "eti228"
        //        }
        //    };
        //    MailAddress fromEmail = new MailAddress("turkanhuseyinbeyli@gmail.com", "Turkan Huseynbayli");
        //    MailAddress toEmail = new MailAddress(email, "Turkan Huseynbayli");
        //    MailMessage message = new MailMessage()
        //    {
        //        From = fromEmail,
        //        Subject = subject,
        //        Body = htmlMessage
        //    };
        //    message.To.Add(toEmail);
        //    client.Send(message);
        //}
    }
}
