using PersonalBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalBlog.Entityes
{
    public class SeedBlogPosts
    {
        public static void SeedBlogData(DBContext context)
        {
            if (!context.Blog.Any())
            {
                context.Blog.Add(
                new BlogModel
                {
                    title = "How to make your company website based on bootstrap framework on localhost",
                    author = "Alex Parker",
                    preview = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Molestiae ut ratione similique temporibus tempora dicta soluta? " +
                    "Qui hic, voluptatem nemo quo corporis dignissimos voluptatum debitis cumque fugiat mollitia quasi quod. " +
                    "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Molestiae ut ratione similique.",
                    fullPost = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin at quam at orci commodo hendrerit vitae nec eros. " +
                    "Vestibulum neque est, imperdiet nec tortor nec, tempor semper metus. Cras vel tempus velit, et accumsan nisi. " +
                    "Duis laoreet pretium ultricies. Curabitur rhoncus auctor nunc congue sodales. Sed posuere nisi ipsum, eget dignissim nunc dapibus eget. " +
                    "Aenean elementum Click me sollicitudin sapien ut sapien fermentum aliquet mollis. Curabitur ac quam orci sodales quam ut tempor. " +
                    "Hover me suspendisse, gravida in augue in, interdum bibendum dui. Suspendisse sit amet justo sit amet diam fringilla commodo. " +
                    "Praesent ac magna at metus malesuada tincidunt non ac arcu. Nunc gravida eu felis vel elementum. Vestibulum sodales quam ut tempor tempor. " +
                    "Donec sollicitudin sapien ut sapien fermentum, non ultricies nulla gravida.",
                    img = "3G63vadcLs.jpg"
                });
            }
            context.SaveChanges();
        }
    }
}
