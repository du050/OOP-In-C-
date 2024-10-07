using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogAdmin
{
    public class Program
    {
        static void Main(string[] args)
        {
            PostCollection posts = new PostCollection();

            News news = new News("1", "Breaking News", "News Description", "News Author", DateTime.Now, Post.Status.published);

            Article article = new Article("2", "Tech Article", "Article Description", "Article Author", DateTime.Now, DateTime.Now, Post.Status.draft, "This is an excerpt");

            posts.AddPost(article);
            posts.AddPost(news);

            Console.WriteLine("\nPosts List:");
            foreach (var post in posts.ListPosts())
            {
                Console.WriteLine(post);
            }

            int publishedCount = posts.CountPostsByStatus(Post.Status.published);
            int draftCount = posts.CountPostsByStatus(Post.Status.draft);

            Console.WriteLine($"\nTotal Published Posts: {publishedCount}");
            Console.WriteLine($"Total Draft Posts: {draftCount}");

            posts.RemovePost(article);

            Console.WriteLine("\nPosts after removal:");
            foreach (var post in posts.ListPosts())
            {
                Console.WriteLine(post);
            }



            Console.ReadKey();
        }
    }
}
