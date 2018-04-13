using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PiwoBack.Data.Models
{
    public class Entity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime CreationDate { get; set; }
        [Required]
        public DateTime ModifiedDate { get; set; }
    }
}
