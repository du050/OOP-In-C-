using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BlogAdmin
{
    public class PostCollection 
    {
        private List<Post> posts = new List<Post>();

        

        public void AddPost(Post post)
        {
            try 
            {
                if (IsEligible(post))
                {
                    this.posts.Add(post);
                }
               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void RemovePost(Post post)
        {
            Post found = GetPost(post.GetId());
            if (found == null)
            {
                throw new Exception("Error: Post does not exist");
            }
            posts.Remove(found);
        }

        public bool HasTitle(string title)
        {
            return posts.Any(el => el.GetTitle() == title);
        }

        

        public bool IsEligible(Post post)
        {
            if(HasTitle(post.GetTitle()))
            {
                throw new Exception($"ERROR: Post does not have TITLE");
            }
            
            return true;
        }

        public Post GetPost(string id)
        {
            return posts.Find(el => el.GetId() == id);
        }

        public List<Post> StatusQuantity(List<Post> posts, Post.Status status)
        {
            return posts.FindAll(el => el.GetStatus() == status);
        }
        public List<Post> ListPosts()
        {
            return posts;
        }
        public int CountPostsByStatus(Post.Status status)
        {
            return posts.Count(el => el.GetStatus() == status);
        }

        
    }
}
