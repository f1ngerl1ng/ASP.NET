using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Intro.Models
{
    public class BlogModel
    {
        public int id { get; set; }
        [Required]
        [MaxLength(30, ErrorMessage ="Name can't exceed 30 characters.")]
        public string author { get; set; }
        [Required]
        [MaxLength(100, ErrorMessage = "Title can't exceed 100 characters.")]
        public string title { get; set; }
        [Required]
        public string preview { get; set; }
        [Required]
        public string fullPost { get; set; }
        public string img { get; set; }
    }
}
