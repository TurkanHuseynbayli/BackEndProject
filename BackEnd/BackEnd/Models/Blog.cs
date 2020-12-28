using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.Models
{
    public class Blog
    {
        public int Id { get; set; }
        [Required]
        public string Image { get; set; }
        public string Name { get; set; }
        public int Comment { get; set; }
        public string Title { get; set; }
        public DateTime DateTime { get; set; }
        public bool isDelete { get; set; }
        public DateTime? DeletedTime { get; set; }
        public BlogDetail Detail { get; set; }
        public int DetailId { get; set; }
        public ICollection<TagBlog> TagBlogs { get; set; }


    }
}
