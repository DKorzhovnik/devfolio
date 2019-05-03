using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace gtbweb.Models
{
    public class BlogPage
    {
        public int BlogPageID { get; set; }
        public int ProfileID { get; set; }
        public int TagID { get; set; }

        public string    HeaderTitle { get; set; } 
        public string   HeaderImage { get; set; } 

        [DataType(DataType.Date)]
        public DateTime CreationDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime LastEditDate { get; set; }
        
        public string Text { get; set; } 

        public virtual Profile Profile { get; set; }
        public virtual Tag Tag { get; set; }

        public virtual ICollection<BlogCollection> BlogCollections { get; set; }
    }
}