using System;
using System.Collections.Generic;

namespace Ecommerce_API.Models
{
    public partial class Game
    {
        public Game()
        {
            GameImages = new HashSet<GameImage>();
            Libraries = new HashSet<Library>();
            OrderDetails = new HashSet<OrderDetail>();
            Cates = new HashSet<Category>();
            Uids = new HashSet<Client>();
            UidsNavigation = new HashSet<Client>();
        }

        public string GameId { get; set; } = null!;
        public string? GameName { get; set; }
        public string? GameDes { get; set; }
        public int? Price { get; set; }
        public string? Thumbnail { get; set; }
        public string? Video { get; set; }
        public string? DevId { get; set; }
        public string? PublisherId { get; set; }

        public virtual Developer? Dev { get; set; }
        public virtual Publisher? Publisher { get; set; }
        public virtual ICollection<GameImage> GameImages { get; set; }
        public virtual ICollection<Library> Libraries { get; set; }
        public virtual ICollection<WishGame> WishLists { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

        public virtual ICollection<Category> Cates { get; set; }
        public virtual ICollection<Client> Uids { get; set; }
        public virtual ICollection<Client> UidsNavigation { get; set; }
    }
}
