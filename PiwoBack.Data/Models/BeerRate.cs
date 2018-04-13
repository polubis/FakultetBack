using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace PiwoBack.Data.Models
{
    public class BeerRate:Entity
    {
        public Beer Beer { get; set; }

        [Required]
        public int Rate { get; set; }

        
    }
}
