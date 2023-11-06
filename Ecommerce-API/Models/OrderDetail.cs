using System;
using System.Collections.Generic;

namespace Ecommerce_API.Models
{
    public partial class OrderDetail
    {
        public string OrderId { get; set; } = null!;
        public string GameId { get; set; } = null!;
        public string? Prices { get; set; }

        public virtual Game Game { get; set; } = null!;
        public virtual Order Order { get; set; } = null!;
    }
}
