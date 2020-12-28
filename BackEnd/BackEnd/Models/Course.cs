using BackEnd.Models.Categories;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.Models
{
    public class Course
    {
        public int Id { get; set; }
        [Required]
        public string Image { get; set; }
        [Required, StringLength(100)]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        public bool isDelete { get; set; }
        public DateTime? DeletedTime { get; set; }
        public virtual CourseDetail CourseDetail { get; set; }
        public int CourseDetailId { get; set; }
        public ICollection<CategoryCourse> CategoryCourses { get; set; }
        public ICollection<TagCourse> TagCourses { get; set; }
    }
}
