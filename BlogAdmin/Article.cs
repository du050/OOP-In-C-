using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogAdmin
{
    public class Article: Post
    {
        string excerpt;

        public Article(string id, string title, string description, string author, DateTime publishAt, DateTime alteredAt, Status postStatus, string excerpt): base(id, title, description, author, publishAt, alteredAt, postStatus, Category.Article)
        {
            
            this.excerpt = excerpt;
        }
    }
}
