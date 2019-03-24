using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace gtbweb.Models
{
    public class Profile
    {
        public int ProfileID { get; set; }
        public int UserID { get; set; }
        public string About { get; set; }
        public string Image { get; set; }
        

        [DataType(DataType.Date)]
        public DateTime RegistrationDate { get; set; }
        public string Designation { get; set; }
        public virtual ICollection<Proficiency> Proficiencies { get; set; }
     
    }
}