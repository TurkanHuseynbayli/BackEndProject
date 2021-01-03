using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.Models
{
    public class About
    {
        public int Id { get; set; }
        [Required,StringLength(150)]
        public string Title { get; set; }
        public string Description { get; set; }
        [Required]
        public string Image { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DeletedTime { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
        //[NotMapped, Required]
        //public IFormFile[] Photos { get; set; }
    }
}
