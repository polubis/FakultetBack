using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using PiwoBack.Data.Models;

namespace PiwoBack.Data.Models
{
    public class User : Entity
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string PasswordHash { get; set; }
        public DateTime RegisterDate { get; set; }
        public UserRole Role { get; set; }

    }
}
