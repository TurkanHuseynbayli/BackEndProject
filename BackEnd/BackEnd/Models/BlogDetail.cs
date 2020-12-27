using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.Models
{
    public class BlogDetail
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public virtual Blog Blog { get; set; }
        public int BlogId { get; set; }
    }
}
