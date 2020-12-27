using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        [Required, StringLength(200)]
        public string Image { get; set; }
        public string Name { get; set; }
        public string Speciality { get; set; }
        public bool IsDelete { get; set; }
        public DateTime? DeletedTime { get; set; }
        public TeacherDetail Detail { get; set; }
        public int TeacherDetail { get; set; }
    }
}
