using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BlogAdmin

{
    public enum Category
    {
        News,
        Article
    }
    public class Post
    {
        public enum Status
        {
            published,
            draft
        }

        string id;
        string title;
        string description;
        string author;
        DateTime publish_at;
        DateTime altered_at;
        Category postCategory;
        Status postStatus;

        public Post(string id, string title, string description, string author, DateTime publish_at, DateTime altered_at, Status postStatus, Category postCategory)
        {
            this.id = id;
            this.title = title;
            this.description = description;
            this.author = author;
            this.publish_at = publish_at;
            this.altered_at = altered_at;
            this.postCategory = postCategory;
            this.postStatus = postStatus;
        }

        public string GetTitle()
        {
            return title;
        }

        public DateTime GetPublishAt()
        {
            return publish_at;
        }

        public Status GetStatus()
        {
            return this.postStatus;
        }

        public string GetId()
        {
            return id;
        }

        public override string ToString()
        {
            return $"\nPost: \nid: {id},\ntitle: {title}, \ndescription {description}, \nauthor {author}, \npublish date: {publish_at}, \nalter date: {altered_at}, \ncategory {postCategory}, \nstatus: {postStatus}";
        }
    }
}
