using System;

namespace Projekt.Models
{
    public class Tag
    {
         public Guid Id{ get; set; }
        public string Name{ get; set; }


        public Tag(String Name)
        {
            this.Id=Guid.NewGuid();
            this.Name=Name;
        }
    }
}