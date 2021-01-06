using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
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
        //public void SendEmail3()
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
        //            UserName = "thuseynbayli@mail.ru",
        //            Password = "Nermin1994"
        //        }
        //    };
        //    MailAddress fromEmail = new MailAddress("thuseynbayli@mail.ru");
        //    MailAddress toEmail = new MailAddress("turkannh@code.edu.az");
        //    MailMessage message = new MailMessage()
        //    {
        //        From = fromEmail,
        //        Subject = "Yoxlama",
        //        Body = "Mesaj geldi",
        //    };
        //    message.To.Add(toEmail);
        //    client.Send(message);
        //}
        //public void SendEmail()
        //{
            
        //    SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
        //    client.UseDefaultCredentials = false;
        //    client.EnableSsl = true;
        //    client.Credentials = new NetworkCredential("turkanhuseyinbeyli@gmail.com", "eti228");
        //    client.DeliveryMethod = SmtpDeliveryMethod.Network;
        //    MailMessage message = new MailMessage("turkanhuseyinbeyli@gmail.com", "kamranfn@code.edu.az");
        //    message.Subject = "Salam";
        //    message.Body = "Salam";

        //    message.BodyEncoding = System.Text.Encoding.UTF8;
        //    message.IsBodyHtml = true;

        //    client.Send(message);

        //}
    }
}
