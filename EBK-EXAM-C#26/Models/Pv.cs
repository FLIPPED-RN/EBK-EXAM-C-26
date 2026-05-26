using System;
using System.Collections.Generic;
using System.Text;

namespace EBK_EXAM_C_26.Models
{
    public partial class Pv
    {
        public int IdPv { get; set; }

        public string Address { get; set; } = null!;

        public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
