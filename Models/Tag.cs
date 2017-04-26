using System;

namespace Projekt.Models
{
    public class Tag
    {
        public Guid Id
        { get; set; }
        public string Name
        { get; set; }
        public Tag(String Name)
        {
            this.Id=Guid.NewGuid();
            setName(Name);
        }
        public void setName(string _name)
        {
            if(string.IsNullOrWhiteSpace(_name))
            {
                throw new Exception("this tag is incorrect");
            }
            else
                this.Name=_name;
        }
    }
}