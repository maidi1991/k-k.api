using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace k_k.Model
{
    public class kukUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Key]
        public int UserID { get; set; }
        public ICollection<kukNotice> Notices { get; set; }
    }
}
