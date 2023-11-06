using System;
using System.Collections.Generic;

namespace Ecommerce_API.Models
{
    public partial class Developer
    {
        public Developer()
        {
            Games = new HashSet<Game>();
        }

        public string DevId { get; set; } = null!;
        public string Developer1 { get; set; } = null!;
        public string? Description { get; set; }
        public string? Logo { get; set; }
        public string? IsActive { get; set; }

        public virtual ICollection<Game> Games { get; set; }
    }
}
