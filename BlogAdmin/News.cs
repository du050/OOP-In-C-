using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogAdmin
{
    public class News : Post
    {
        public News(string id, string title, string description, string author,  DateTime altered_at, Status postStatus) : base(id, title, description, author, DateTime.Now, altered_at, postStatus, Category.News)
        {
        }
    }
}
