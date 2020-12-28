using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.Models
{
    public class Contact
    {
        public int Id { get; set; }
        [Required]
        public string Adress { get; set; }
        public string Phone { get; set; }
        public string Place { get; set; }
    }
}
