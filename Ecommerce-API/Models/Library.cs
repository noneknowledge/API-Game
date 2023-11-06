using System;
using System.Collections.Generic;

namespace Ecommerce_API.Models
{
    public partial class Library
    {
        public string Uid { get; set; } = null!;
        public string GameId { get; set; } = null!;
        public int? PlayTime { get; set; }
        public string? FeedBack { get; set; }

        public virtual Game Game { get; set; } = null!;
        public virtual Client UidNavigation { get; set; } = null!;
    }
}
