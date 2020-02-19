using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PersonalBlog.Data.Interfaces;
using PersonalBlog.Entityes;
using PersonalBlog.Models;
using PersonalBlog.ViewModel;

namespace PersonalBlog.Controllers
{
    public class BlogController : Controller
    {
        private readonly IPostRepository _postRepository;
        private readonly IHostingEnvironment hostingEnvironment;
        private readonly ILogger logger;

        public BlogController(DBContext context, IPostRepository postRepository,
            IHostingEnvironment hostingEnvironment, ILogger<BlogController> logger)
        {
            _postRepository = postRepository;
            this.hostingEnvironment = hostingEnvironment;
            this.logger = logger;

        }

        [Route("Blog/Post/{id}")]
        public IActionResult Post(int id)
        {

            logger.LogTrace("Trace Log");
            logger.LogDebug("Debug Log");
            logger.LogInformation("Information Log");
            logger.LogWarning("Warning Log");
            logger.LogError("Error Log");
            logger.LogCritical("Critical Log");
            var post = _postRepository.GetPostById(id);

            if (post == null)
            {
                Response.StatusCode = 404;
                return View("PostNotFound", id);
            }

            return View(post);
        }
        
        public IActionResult Blog()
        {
            var posts = _postRepository.GetAllPosts().Reverse().ToList(); ;
            
            return View(posts);
        }
        [HttpGet]
        public ViewResult Edit(int id)
        {
            BlogModel post = _postRepository.GetPostById(id);
            PostEditViewModel postEditViewModel = new PostEditViewModel
            { 
                id = post.id,
                title = post.title,
                author = post.author,
                preview = post.preview, 
                fullPost = post.fullPost, 
                ExistImgPath = post.img
            };

            return View(postEditViewModel);
        }

        [HttpPost]
        public IActionResult Edit(PostEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                BlogModel post = _postRepository.GetPostById(model.id);
                post.author = model.author;
                post.title = model.title;
                post.preview = model.preview;
                post.fullPost = model.fullPost;

                if (model.img != null)
                {
                    if (model.ExistImgPath != null)
                    {
                        string filePath = Path.Combine(hostingEnvironment.WebRootPath, "img/blog", model.ExistImgPath);
                        System.IO.File.Delete(filePath);
                    }
                    post.img = UploadedFile(model);
                }

                _postRepository.UpdatePost(post);
                return RedirectToAction("Blog");
            }
            return View();
        }
        public IActionResult Delete(int id)
        {
           
            _postRepository.DeletePost(id);

            return RedirectToAction("Blog");
        }
        private string UploadedFile(PostEditViewModel model)
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

            return uniqFileName;
        }
    }
}