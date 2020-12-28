using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.Models
{
    public class TagBlog
    {
        public int Id { get; set; }
        public virtual Tag Tag { get; set; }
        public int TagsId { get; set; }
        public virtual Blog Blog { get; set; }
        public int BlogId { get; set; }
    }
}
