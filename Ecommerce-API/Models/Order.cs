using System;
using System.Collections.Generic;

namespace Ecommerce_API.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public string OrderId { get; set; } = null!;
        public string Uid { get; set; } = null!;
        public DateTime? OrderDate { get; set; }
        public string? PaymentId { get; set; }
        public int? Amount { get; set; }
        public string? DiscountId { get; set; }
        public int? Total { get; set; }

        public virtual Discount? Discount { get; set; }
        public virtual Client UidNavigation { get; set; } = null!;
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
