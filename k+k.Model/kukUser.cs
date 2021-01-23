using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace k_k.Model
{
    public class kukUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Key]
        public int UserID { get; set; }
        public ICollection<kukNotice> Notices { get; set; }
    }
}
