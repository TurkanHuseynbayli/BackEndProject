using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.Models
{
    public class EventDetail
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Reply { get; set; }
        public virtual Event Event { get; set; }
        public int EventId { get; set; }
        public List<Speaker> Speaker { get; set; }
    }
}
