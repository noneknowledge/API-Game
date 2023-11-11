using System;
using System.Collections.Generic;

namespace Ecommerce_API.Models
{
    public partial class ShoppingCart
    {
        public string GameId { get; set; } = null!;
        public string Uid { get; set; } = null!;
        public string? Des { get; set; }

        public virtual Game Game { get; set; } = null!;
        public virtual Client UidNavigation { get; set; } = null!;
    }
}
