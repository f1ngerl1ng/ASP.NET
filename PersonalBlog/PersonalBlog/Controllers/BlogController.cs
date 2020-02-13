using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonalBlog.Data.Interfaces;
using PersonalBlog.Entityes;





namespace PersonalBlog.Controllers
{
    public class BlogController : Controller
    {
        private readonly IPostRepository _postRepository;

        public BlogController(DBContext context, IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        [Route("Blog/Post/{id}")]
        public IActionResult Post(int id)
        {
            var post = _postRepository.GetPostById(id);

            return View(post);
        }

        public IActionResult Blog()
        {
            var posts = _postRepository.GetAllPosts().Reverse().ToList(); ;
            
            return View(posts);
        }
        [HttpPost]
        public ViewResult Edit()
        {
            return View();
        }

        public IActionResult Delete(int id)
        {

            
               

                return View();
           
            

            
        }
    }
}