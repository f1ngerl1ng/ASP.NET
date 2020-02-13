using Microsoft.EntityFrameworkCore;
using PersonalBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalBlog.Entityes
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {

        }
        public DbSet<BlogModel> Blog { get; set; }

    
    }
}
