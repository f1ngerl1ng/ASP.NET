using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalBlog.Models
{
    public class AppUser : IdentityUser
    {
        public string City { get; set; }

        //public string img { get; set; }
    }
}
