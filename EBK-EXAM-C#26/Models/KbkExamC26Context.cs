using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBK_EXAM_C_26.Models
{
    public partial class KbkExamC26Context : DbContext
    {
        public KbkExamC26Context() { }

        public KbkExamC26Context(DbContextOptions<KbkExamC26Context> options)
                : base(options)
        {
        }

        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Pv> Pvs { get; set;  }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

    }
}
