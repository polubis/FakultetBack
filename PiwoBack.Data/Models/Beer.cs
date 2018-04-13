using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PiwoBack.Data.Models
{
    public class Beer : Entity
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public double Alcohol { get; set; }
        [Required]
        public double Price { get; set; }
        public string Color { get; set; }
        public string Country { get; set; }
        public double? Ibu { get; set; }
        public double? Blg { get; set; }
        public Brewery Brewery { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<BeerRate> BeerRates { get; set; }
    }
}
