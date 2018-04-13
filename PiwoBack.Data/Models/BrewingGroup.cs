using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PiwoBack.Data.Models
{
    public class BrewingGroup : Entity
    {
        [Required]
        public string Name { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public string Director { get; set; }
        public DateTime CreateDate { get; set; }
        public virtual ICollection<Brewery> Breweries { get; set; }

    }
}
