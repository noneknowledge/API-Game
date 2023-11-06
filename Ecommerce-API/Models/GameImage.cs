using System;
using System.Collections.Generic;

namespace Ecommerce_API.Models
{
    public partial class GameImage
    {
        public string GameId { get; set; } = null!;
        public string ImageId { get; set; } = null!;
        public string? ImageName { get; set; }
        public string? ImageDes { get; set; }
        public string? AdminId { get; set; }

        public virtual Game Game { get; set; } = null!;
    }
}
