using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalBlog.Models
{
    public class BlogModel
    {
        public int id { get; set; }
       
        public string author { get; set; }
       
        public string title { get; set; }
        [Required]
        public string preview { get; set; }
        [Required]
        public string fullPost { get; set; }
        public string img { get; set; }
    }
}
