using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.Models
{
    public class Board
    {
        public int Id { get; set; }
        [Required,DataType(DataType.DateTime)]
        public DateTime Time { get; set; }
        public string Description { get; set; }
    }
}
