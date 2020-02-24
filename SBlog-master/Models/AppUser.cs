using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace MVC_Intro.Models
{
    public class AppUser : IdentityUser
    {
        public string City { get; set; }
    }
}
