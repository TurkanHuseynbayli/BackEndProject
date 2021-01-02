using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.Models
{
    public class TeacherDetail
    {
        public int Id { get; set; }
        public string About { get; set; }
        [Required]
        public string Degree { get; set; }
        [Required]
        public string Experience { get; set; }
        [Required]
        public string Hobbies { get; set; }
        [Required]
        public string Faculty { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Skype { get; set; }
        public string Facebook { get; set; }
        public string Pinterest { get; set; }
        public string Vimeo { get; set; }
        public string Twitter { get; set; }
        public int Language { get; set; }
        public int Design { get; set; }
        public int TeamLeader { get; set; }
        public int Innovation { get; set; }
        public int Development { get; set; }
        public int Communication { get; set; }
        [ForeignKey("Teacher")]
        public int TeacherId { get; set; }
        public  Teacher Teacher { get; set; }
        

    }
}
