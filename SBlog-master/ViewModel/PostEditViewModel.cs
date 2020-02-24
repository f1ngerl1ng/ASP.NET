using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Intro.ViewModel
{
    public class PostEditViewModel : PostCreateViewModel
    {
        public int Id { get; set; }
        public string ExistImgPath { get; set; }

    }
}
