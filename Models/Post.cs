using System;
using System.Collections.Generic;

namespace Projekt.Models
{
    public class Post
    {
        public Guid Id
        { get; set; }
 
        public string Title
        { get; set; }
 
        public string Description
        { get; set; }
 
        public string Content
        { get; set; }
 
        public string UrlSlug
        { get; set; }
 
        public DateTime PostedOn
        { get; set; }
 
        public DateTime Modified
        { get; set; }
 
        public  IList<Tag> Tags
        { get; set; }


        public Post(string Title, string Description, string Content)
        {   
            this.Id=Guid.NewGuid();
            this.Title=Title;
            this.Description=Description;
            this.Content=Content;
            this.PostedOn=DateTime.Now;

        }
    }
}