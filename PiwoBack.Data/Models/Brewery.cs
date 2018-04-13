using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PiwoBack.Data.Models
{
    public class Brewery : Entity
    {
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public BrewingGroup BrewingGroup { get; set; }
        public virtual ICollection<Beer> Beers { get; set; }
    }
}
