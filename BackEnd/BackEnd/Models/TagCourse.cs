using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.Models
{
    public class TagCourse
    {
        public int Id { get; set; }

        public virtual Tag Tag { get; set; }
        public int TagId { get; set; }
        public virtual Course Course { get; set; }
        public int CourseId { get; set; }
    }
}
