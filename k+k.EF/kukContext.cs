using k_k.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace k_k.EF
{
    namespace EF6Console
    {
        public class KuKContext : DbContext
        {
            public KuKContext() : base()
            {
            }

            public DbSet<kukUser> Users { get; set; }
            public DbSet<kukNotice> Notices { get; set; }
        }
    }
}
