using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.Models.Categories
{
    public class Category
    {
        public int Id { get; set; }
        public string NameCategory { get; set; }
        public int Count { get; set; }
        public ICollection<CategoryCourse> CategoryCourses { get; set; }
        
    }
}
