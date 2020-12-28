using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.Models.Categories
{
    public class CategoryCourse
    {
        public int Id { get; set; }
        public virtual Category Category { get; set; }
        public int  CategoryId { get; set; }
        public virtual Course Course { get; set; }
        public int CourseId { get; set; }

    }
}
