using System;
using System.Collections.Generic;

namespace Ecommerce_API.Models
{
    public partial class Publisher
    {
        public Publisher()
        {
            Games = new HashSet<Game>();
        }

        public string PublisherId { get; set; } = null!;
        public string? Publisher1 { get; set; }
        public string Description { get; set; } = null!;
        public string Logo { get; set; } = null!;
        public string? IsActive { get; set; }

        public virtual ICollection<Game> Games { get; set; }
    }
}
