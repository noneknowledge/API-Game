using System;
using System.Collections.Generic;

namespace Ecommerce_API.Models
{
    public partial class Category
    {
        public Category()
        {
            Games = new HashSet<Game>();
        }

        public string CateId { get; set; } = null!;
        public string? CateName { get; set; }
        public string? CateDes { get; set; }

        public virtual ICollection<Game> Games { get; set; }
    }
}
