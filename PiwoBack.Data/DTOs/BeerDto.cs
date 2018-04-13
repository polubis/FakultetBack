using PiwoBack.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PiwoBack.Data.DTOs
{
    public class BeerDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Alcohol { get; set; }
        public double Price { get; set; }
        public string Color { get; set; }
        public string Country { get; set; }
        public double Ibu { get; set; }
        public double Blg { get; set; }
        public Brewery Brewery { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
