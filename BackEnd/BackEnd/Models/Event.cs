using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Image { get; set; }
        [Required, DataType(DataType.DateTime)]
        public DateTime Date { get; set; }
        [Required]
        public string Title { get; set; }       
        public string Place { get; set; }
        public bool isDelete { get; set; }
        public DateTime? DeletedTime { get; set; }
        public virtual EventDetail EventDetail { get; set; }
        public int EventDetailId { get; set; }
        public ICollection<TagEvent> TagsEvents { get; set; }
    }
}
