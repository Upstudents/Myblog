using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Projekt.Models
{
    public class Post
    {
        
        private Guid Id
        { get; set; }

        [Required(ErrorMessage = "Musisz wprowadzić tytuł")]
        [StringLength(18, ErrorMessage = "Tytuł powinno zawierać przynajmniej 3, a maksymalnie 18 znaków", MinimumLength = 3)]        
        public string Title
        { get; set; }
        
        public string Description
        { get; set; }
        
        [Required(ErrorMessage = "Musisz wprowadzić treść")]
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
        /*public Post(string Title, string Description, string Content)
        {   
            this.Id=Guid.NewGuid();
            setTitle(Title);
            setDescription(Description);
            setContent(Content);
            this.PostedOn=DateTime.Now;
        }
        public void setTitle(string _title)
        {
            if(string.IsNullOrWhiteSpace(_title))
            {
                throw new Exception("this title is incorrect");
            }
            else
                this.Title=_title;
        }
        public void setDescription(string _description)
        {
            if(string.IsNullOrWhiteSpace(_description))
            {
                throw new Exception("this description is incorrect");
            }
            else
                this.Description=_description;
        }

        public void setContent(string _content)
        {
            if(string.IsNullOrWhiteSpace(_content))
            {
                throw new Exception("this content is incorrect");
            }
            else
                this.Content=_content;
        }
*/
    }
}