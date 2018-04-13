using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using PiwoBack.Data.Models;

namespace PiwoBack.Data.Models
{
    public class Comment : Entity
    {
        [Required]
        public string Content { get; set; }
        [Required]
        public Beer Beer { get; set; }
        [Required]
        public User Author { get; set; }
    }
}
