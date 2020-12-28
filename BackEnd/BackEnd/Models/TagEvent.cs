using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.Models
{
    public class TagEvent
    {
        public int Id { get; set; }
        public Tag Tag { get; set; }
        public int TagId { get; set; }
        public Event Event { get; set; }
        public int EventId { get; set; }
    }
}
