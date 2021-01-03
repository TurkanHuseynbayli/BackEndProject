using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.Models
{
    public class Testimonial
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        [NotMapped]
        [Required]
        public IFormFile Photo { get; set; }
        //public IFormFile Photo { get; set; }
        //[NotMapped, Required]
        //public IFormFile[] Photos { get; set; }
    }
}
