using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalBlog.ViewModel
{
    public class PostEditViewModel : PostCreateViewModel
    {
        public int id { get; set; }
        public string ExistImgPath { get; set; }

    }
}
