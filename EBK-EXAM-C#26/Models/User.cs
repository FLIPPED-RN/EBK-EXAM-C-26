using System;
using System.Collections.Generic;
using System.Text;

namespace EBK_EXAM_C_26.Models
{
    public partial class User
    {
        public string Login { get; set; } = null!;

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string SurName { get; set; } = null!;

        public string Role { get; set; } = null!;

        public string Password { get; set; } = null!;

        public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
