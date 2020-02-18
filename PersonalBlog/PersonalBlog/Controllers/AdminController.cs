﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using PersonalBlog.Data.Interfaces;
using PersonalBlog.Models;
using PersonalBlog.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalBlog.Controllers
{
    public class AdminController : Controller
    {

        private IPostRepository _postRep;
        private IHostingEnvironment hostingEnvironment;

        public AdminController(IPostRepository postRep, IHostingEnvironment hostingEnvironment)
        {
            _postRep = postRep;
            this.hostingEnvironment = hostingEnvironment;
        }
        public IActionResult Admin()
        {
            return View();
        }
        public IActionResult PostEditor(int postID)
        {
            return View();
        }

        [HttpGet]
        public ViewResult CreatePost()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreatePost(PostCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                string uniqFileName = null;
                if (model.img != null)
                {
                    string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "img/blog");
                    uniqFileName = Guid.NewGuid().ToString() + "_" + model.img.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqFileName);
                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        model.img.CopyTo(fileStream);
                    }

                }
                BlogModel newPost = new BlogModel
                {
                    author = model.author,
                    title = model.title,
                    preview = model.preview,
                    fullPost = model.fullPost,
                    img = uniqFileName
                };
                _postRep.CreatePost(newPost);
                return RedirectToRoute("default", new { controller = "Blog", action = "Post", id = newPost.id });
            }
            return View();
        }
    }
}
