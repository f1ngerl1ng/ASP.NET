using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC_Intro.Models;

namespace MVC_Intro.Entityes
{
    public class SeedBlogPosts
    {
        public static void SeedBlogData(DBContext context)
        {
            if (!context.Blog.Any())
            {
                context.Blog.Add(
                new BlogModel {
                    author = "Neo",
                    title = "RESUME VS COVER LETTER: MAIN DIFFERENCES BETWEEN",
                    preview = "Do you know that a resume and a cover letter actually differ? Even though both of" +
                    " these documents are essential when applying for a job, it is critical that you know how to " +
                    "differentiate them in order to write them for the right purpose. Resume vs cover letter should" +
                    " be properly defined so that you",
                    fullPost = "Do you know that a resume and a cover letter actually differ? Even though both of " +
                    "these documents are essential when applying for a job, it is critical that you know how to" +
                    " differentiate them in order to write them for the right purpose. Resume vs cover letter should" +
                    " be properly defined so that you understand what aim each of them has. When writing either a" +
                    " resume or a cover letter, you should demonstrate your skills and competencies in order to prove" +
                    " to the employer or HR manager that you are worth being considered for the position. Ideally," +
                    " both a resume and a cover letter should pinpoint that you have skills that are relevant and " +
                    "corresponding to the job opening. As you start working on the resume or a cover letter, " +
                    "be sure that you should come to realize the resume vs cover letter structure and mode or " +
                    "organization.Moreover,it is essential to adhere to the template and follow the general" +
                    " requirements as well as the resume cover letter format. First of all, a resume and a cover " +
                    "letter are not the same and each of them has a different structure and purpose.Second",
                    img = "resume-vs-cover-letter.jpg"
                });
            }
            context.SaveChanges();
        }
    }
}
