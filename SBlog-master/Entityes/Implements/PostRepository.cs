using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVC_Intro.Data.Interfaces;
using MVC_Intro.Models;

namespace MVC_Intro.Entityes.Implements
{
    public class PostRepository : IPostRepository
    {
        private readonly DBContext context;
        public PostRepository(DBContext context)
        {
            this.context = context;
        }

        public BlogModel CreatePost(BlogModel post)
        {
            context.Blog.Add(post);
            context.SaveChanges();
            return post;
        }

        public BlogModel DeletePost(int Id)
        {
            BlogModel post = context.Blog.Find(Id);
            if (post != null)
            {
                context.Blog.Remove(post);
                context.SaveChanges();
            }
            return post;
        }

        public IEnumerable<BlogModel> GetAllPosts()
        {
            return context.Blog;
        }

        public BlogModel GetPostById(int Id)
        {
            return context.Blog.Find(Id);
        }

        public BlogModel UpdatePost(BlogModel newPost)
        {
            var post = context.Blog.Attach(newPost);
            post.State = EntityState.Modified;
            context.SaveChanges();
            return newPost;
        }
    }
}
