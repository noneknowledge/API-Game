using System;
using System.Collections.Generic;

namespace Ecommerce_API.Models
{
    public partial class Discount
    {
        public Discount()
        {
            Orders = new HashSet<Order>();
        }

        public string DiscountId { get; set; } = null!;
        public string? Description { get; set; }
        public string? DiscountType { get; set; }
        public int DiscountValue { get; set; }
        public string? Code { get; set; }
        public string? AdminId { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
