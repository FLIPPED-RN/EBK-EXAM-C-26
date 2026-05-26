using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace EBK_EXAM_C_26.Models
{
    public partial class Order
    {
        public int IdOrder { get; set;  }
        public string Articul { get; set; } = null!;
        public int Quantity { get; set;  }
        public DateOnly Date {  get; set; }
        public int IdPv { get; set; }
        public DateOnly DatePost { get; set;  }
        public string Login { get; set; } = null!;
        public int Code { get; set; }
        public string Status { get; set; } = null!;
        public virtual Product ArticulNavigation { get; set; } = null!;
        public virtual Pv IdPvNavigation { get; set; } = null!;
        public virtual User LoginNavigation { get; set; } = null!;
    }
}
