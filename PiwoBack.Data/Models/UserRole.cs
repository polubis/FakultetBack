using System;
using System.Collections.Generic;
using System.Text;
using PiwoBack.Data.Models;

namespace PiwoBack.Data.Models
{
    public class UserRole : Entity
    {
        public string Role { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
